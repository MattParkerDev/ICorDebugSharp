using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Markdig;
using Markdig.Extensions.Tables;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;

namespace DocsGenerator;

internal sealed partial class MarkdownXmlRenderer
{
	private readonly MarkdownPipeline _pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
	private readonly IReadOnlyDictionary<string, string> _crefsByUrl;

	public MarkdownXmlRenderer(IReadOnlyDictionary<string, string> crefsByUrl)
	{
		_crefsByUrl = crefsByUrl;
	}

	public string Render(string markdown, string sourceUrl)
	{
		var output = new StringBuilder();
		var document = Markdown.Parse(markdown, _pipeline);
		foreach (var block in document)
			RenderBlock(output, block, sourceUrl);
		return output.ToString().Trim();
	}

	private void RenderBlock(StringBuilder output, Block block, string sourceUrl)
	{
		switch (block)
		{
			case ParagraphBlock paragraph:
				output.Append("<para>");
				RenderInlines(output, paragraph.Inline, sourceUrl);
				output.AppendLine("</para>");
				break;
			case ListBlock list:
				output.AppendLine($"<list type=\"{(list.IsOrdered ? "number" : "bullet")}\">");
				foreach (var item in list.OfType<ListItemBlock>())
				{
					output.Append("<item><description>");
					foreach (var child in item)
						RenderBlock(output, child, sourceUrl);
					output.AppendLine("</description></item>");
				}
				output.AppendLine("</list>");
				break;
			case QuoteBlock quote:
				output.Append("<para><b>Note:</b> ");
				var quoteText = ExtractPlainText(quote).Trim();
				quoteText = AlertPrefixRegex().Replace(quoteText, "");
				output.Append(WebUtility.HtmlEncode(quoteText));
				output.AppendLine("</para>");
				break;
			case FencedCodeBlock code:
				output.Append("<code>");
				output.Append(WebUtility.HtmlEncode(string.Concat(code.Lines.Lines.Select(line => line.ToString()))));
				output.AppendLine("</code>");
				break;
			case Table table:
				RenderTable(output, table, sourceUrl);
				break;
			case ContainerBlock container:
				foreach (var child in container)
					RenderBlock(output, child, sourceUrl);
				break;
		}
	}

	private void RenderTable(StringBuilder output, Table table, string sourceUrl)
	{
		output.AppendLine("<list type=\"table\">");
		var rows = table.OfType<TableRow>().ToArray();
		if (rows.Length > 0 && rows[0].IsHeader)
		{
			output.Append("<listheader>");
			RenderTableCells(output, rows[0], sourceUrl, "term", "description");
			output.AppendLine("</listheader>");
		}
		foreach (var row in rows.Where(row => !row.IsHeader))
		{
			output.Append("<item>");
			RenderTableCells(output, row, sourceUrl, "term", "description");
			output.AppendLine("</item>");
		}
		output.AppendLine("</list>");
	}

	private void RenderTableCells(
		StringBuilder output,
		TableRow row,
		string sourceUrl,
		string firstElement,
		string otherElement)
	{
		var index = 0;
		foreach (var cell in row.OfType<TableCell>())
		{
			var element = index++ == 0 ? firstElement : otherElement;
			output.Append('<').Append(element).Append('>');
			foreach (var block in cell)
			{
				if (block is ParagraphBlock paragraph)
					RenderInlines(output, paragraph.Inline, sourceUrl);
				else
					RenderBlock(output, block, sourceUrl);
			}
			output.Append("</").Append(element).Append('>');
		}
	}

	private void RenderInlines(StringBuilder output, ContainerInline? container, string sourceUrl)
	{
		for (var inline = container?.FirstChild; inline is not null; inline = inline.NextSibling)
		{
			switch (inline)
			{
				case LiteralInline literal:
					output.Append(WebUtility.HtmlEncode(literal.Content.ToString()));
					break;
				case CodeInline code:
					output.Append("<c>").Append(WebUtility.HtmlEncode(code.Content)).Append("</c>");
					break;
				case EmphasisInline emphasis:
					var element = emphasis.DelimiterCount >= 2 ? "b" : "i";
					output.Append('<').Append(element).Append('>');
					RenderInlines(output, emphasis, sourceUrl);
					output.Append("</").Append(element).Append('>');
					break;
				case LinkInline link:
					var url = ResolveUrl(link.Url, sourceUrl);
					if (_crefsByUrl.TryGetValue(url, out var cref))
						output.Append("<see cref=\"").Append(WebUtility.HtmlEncode(cref)).Append("\">");
					else
						output.Append("<see href=\"").Append(WebUtility.HtmlEncode(url)).Append("\">");
					RenderInlines(output, link, sourceUrl);
					output.Append("</see>");
					break;
				case LineBreakInline:
					output.Append("<br/>");
					break;
				case HtmlInline html:
					RenderHtmlInline(output, html.Tag);
					break;
				case ContainerInline nested:
					RenderInlines(output, nested, sourceUrl);
					break;
			}
		}
	}

	private static void RenderHtmlInline(StringBuilder output, string tag)
	{
		var xref = XrefRegex().Match(tag);
		if (xref.Success)
		{
			output.Append("<see cref=\"").Append(WebUtility.HtmlEncode(xref.Groups["cref"].Value)).Append("\"/>");
			return;
		}
		if (tag.Equals("<br>", StringComparison.OrdinalIgnoreCase) ||
			tag.Equals("<br/>", StringComparison.OrdinalIgnoreCase) ||
			tag.Equals("<br />", StringComparison.OrdinalIgnoreCase))
		{
			output.Append("<br/>");
			return;
		}
		output.Append(WebUtility.HtmlEncode(tag));
	}

	private static string ResolveUrl(string? url, string sourceUrl)
	{
		if (string.IsNullOrWhiteSpace(url))
			return sourceUrl;
		if (!Uri.TryCreate(url, UriKind.Absolute, out var absolute))
			absolute = new Uri(new Uri(sourceUrl), url);
		var result = absolute.AbsoluteUri;
		var markdownExtension = result.IndexOf(".md", StringComparison.OrdinalIgnoreCase);
		if (markdownExtension >= 0)
			result = result.Remove(markdownExtension, 3);
		return result;
	}

	private static string ExtractPlainText(Block block)
	{
		var builder = new StringBuilder();
		foreach (var descendant in block.Descendants())
		{
			if (descendant is LiteralInline literal)
				builder.Append(literal.Content).Append(' ');
			else if (descendant is CodeInline code)
				builder.Append(code.Content).Append(' ');
		}
		return builder.ToString();
	}

	[GeneratedRegex(@"^\[!(?:NOTE|TIP|IMPORTANT|WARNING|CAUTION)\]\s*", RegexOptions.IgnoreCase)]
	private static partial Regex AlertPrefixRegex();

	[GeneratedRegex("^<xref:(?<cref>[^?/>]+)(?:\\?[^>]*)?/?>$", RegexOptions.IgnoreCase)]
	private static partial Regex XrefRegex();
}
