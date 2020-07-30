using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmercalc.web
{
    public class GoogleAdsenseTagHelper : TagHelper
    {
        public string AdClient { get; set; }
        public string AdSlot { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.SuppressOutput();

            if (!String.IsNullOrEmpty(AdClient) && !String.IsNullOrEmpty(AdSlot) && Width > 0 && Height > 0)
            {
                var sb = new StringBuilder();
                sb.AppendLine("<script async src=\"//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js\"></script>");
                sb.AppendLine("<ins class=\"adsbygoogle\"");
                sb.AppendLine($"data-ad-format=\"auto\" data-full-width-responsive = \"true\"");
                sb.AppendLine($"     data-ad-client=\"{AdClient}\"");
                sb.AppendLine($"     data-ad-slot=\"{AdSlot}\"></ins>");
                sb.AppendLine("<script>");
                sb.AppendLine("(adsbygoogle = window.adsbygoogle || []).push({});");
                sb.AppendLine("</script>");

                output.Content.SetHtmlContent(sb.ToString());
            }
        }
    }
}
