#pragma checksum "c:\users\shx8rkd\source\repos\MongoDBEx\MongoDBEx\Views\Home\JSONtoMongo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4966fa45caacc7d370e76466b191472061a31833"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_JSONtoMongo), @"mvc.1.0.view", @"/Views/Home/JSONtoMongo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/JSONtoMongo.cshtml", typeof(AspNetCore.Views_Home_JSONtoMongo))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "c:\users\shx8rkd\source\repos\MongoDBEx\MongoDBEx\Views\_ViewImports.cshtml"
using MongoDBEx;

#line default
#line hidden
#line 2 "c:\users\shx8rkd\source\repos\MongoDBEx\MongoDBEx\Views\_ViewImports.cshtml"
using MongoDBEx.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4966fa45caacc7d370e76466b191472061a31833", @"/Views/Home/JSONtoMongo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"303fbb45a03b17b6f3b15acbf8fbe3e6349865f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_JSONtoMongo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HomeController/JSONtoMongo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "c:\users\shx8rkd\source\repos\MongoDBEx\MongoDBEx\Views\Home\JSONtoMongo.cshtml"
  
    ViewData["Title"] = "JSONtoMongo";

#line default
#line hidden
#line 5 "c:\users\shx8rkd\source\repos\MongoDBEx\MongoDBEx\Views\Home\JSONtoMongo.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(79, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(88, 17, false);
#line 7 "c:\users\shx8rkd\source\repos\MongoDBEx\MongoDBEx\Views\Home\JSONtoMongo.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(105, 15, true);
            WriteLiteral("</h2>\r\n    <h4>");
            EndContext();
            BeginContext(121, 18, false);
#line 8 "c:\users\shx8rkd\source\repos\MongoDBEx\MongoDBEx\Views\Home\JSONtoMongo.cshtml"
   Write(ViewData["return"]);

#line default
#line hidden
            EndContext();
            BeginContext(139, 11, true);
            WriteLiteral("</h4>\r\n    ");
            EndContext();
            BeginContext(150, 189, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "622ad53650a44911857f0963d82fa0a9", async() => {
                BeginContext(210, 122, true);
                WriteLiteral("\r\n        <input type=\"text\" name=\"ven6\" id=\"ven6\" />\r\n        <br />\r\n        <button type=\"submit\">Submit</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(339, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "c:\users\shx8rkd\source\repos\MongoDBEx\MongoDBEx\Views\Home\JSONtoMongo.cshtml"
}

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(460, 24, true);
                WriteLiteral("\r\n    <script>\r\n        ");
                EndContext();
                BeginContext(485, 26, false);
#line 19 "c:\users\shx8rkd\source\repos\MongoDBEx\MongoDBEx\Views\Home\JSONtoMongo.cshtml"
   Write(Html.Raw(ViewData["code"]));

#line default
#line hidden
                EndContext();
                BeginContext(511, 18, true);
                WriteLiteral(";\r\n    </script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591