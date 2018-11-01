using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace UserFps.TagHelpers
{
    // Tag helper class that adds "asp-encode" attribute to script tags
    // Helps obfuscate the script code with Base64 encoding.
    [HtmlTargetElement("script")]
    [HtmlTargetElement("script", Attributes = "asp-encode")]
    [HtmlTargetElement("script", Attributes = "asp-src-include")]
    [HtmlTargetElement("script", Attributes = "asp-src-exclude")]
    [HtmlTargetElement("script", Attributes = "asp-fallback-src")]
    [HtmlTargetElement("script", Attributes = "asp-fallback-src-include")]
    [HtmlTargetElement("script", Attributes = "asp-fallback-src-exclude")]
    [HtmlTargetElement("script", Attributes = "asp-fallback-test")]
    [HtmlTargetElement("script", Attributes = "asp-append-version")]
    public class InlineScriptTagHelper : ScriptTagHelper
    {
        public InlineScriptTagHelper(IHostingEnvironment hostingEnvironment,
                                     IMemoryCache cache,
                                     HtmlEncoder htmlEncoder,
                                     JavaScriptEncoder javaScriptEncoder,
                                     IUrlHelperFactory urlHelperFactory)
         : base(hostingEnvironment, cache, htmlEncoder, javaScriptEncoder, urlHelperFactory)
        {

        }

        [HtmlAttributeName("asp-encode")]
        public bool Encode { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if ((this.Encode == true) && (string.IsNullOrWhiteSpace(this.Src) == true))
            {

                var content = output.GetChildContentAsync().GetAwaiter().GetResult().GetContent();
                var encodedContent = Convert.ToBase64String(Encoding.ASCII.GetBytes(content));
                var script = $"data:text/javascript;base64,{encodedContent}";

                output.Attributes.Add("src", script);
                output.Content.Clear();
            }

            base.Process(context, output);
        }

    }
}
