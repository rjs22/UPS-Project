#pragma checksum "C:\Users\SHX8RKD\source\repos\SimpleLogin\SimpleLogin\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5da36cca5ae8e6f3d0eb6aa03b73c23c75032dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
#line 1 "C:\Users\SHX8RKD\source\repos\SimpleLogin\SimpleLogin\Views\_ViewImports.cshtml"
using SimpleLogin;

#line default
#line hidden
#line 2 "C:\Users\SHX8RKD\source\repos\SimpleLogin\SimpleLogin\Views\_ViewImports.cshtml"
using SimpleLogin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5da36cca5ae8e6f3d0eb6aa03b73c23c75032dc", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18093421fb92bac695e347ddad23e878b27b1832", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HomeController/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\SHX8RKD\source\repos\SimpleLogin\SimpleLogin\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(43, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(50, 18, false);
#line 6 "C:\Users\SHX8RKD\source\repos\SimpleLogin\SimpleLogin\Views\Home\Login.cshtml"
Write(ViewData["return"]);

#line default
#line hidden
            EndContext();
            BeginContext(68, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\SHX8RKD\source\repos\SimpleLogin\SimpleLogin\Views\Home\Login.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(107, 536, true);
            WriteLiteral(@"    <div class=""container-fluid ups-signin"" style=""padding-left: 30%; padding-right: 30%;"">
        <div class=""row"">
            <div class=""col-lg-12  body-content"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <strong>Sign in to <span class=""hidden-400"">continue</span> <span class=""show-400""></span> </strong>
                    </div>
                    <div class=""panel-body"">
                        <section>

                            ");
            EndContext();
            BeginContext(643, 4376, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75228ed982b944aca0516775db163db9", async() => {
                BeginContext(697, 379, true);
                WriteLiteral(@"
                                <fieldset>
                                    <div class=""row hidden-400"">
                                        <div class=""col-lg-12 text-center"">
                                            <h3>Sign In</h3>
                                        </div>
                                    </div>
                                    ");
                EndContext();
                BeginContext(1076, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71164d249b3b46f4925036efac207af8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 27 "C:\Users\SHX8RKD\source\repos\SimpleLogin\SimpleLogin\Views\Home\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1136, 124, true);
                WriteLiteral("\r\n                                    <div class=\"row\">\r\n                                        <div class=\"col-lg-12\">\r\n\r\n");
                EndContext();
                BeginContext(1320, 644, true);
                WriteLiteral(@"                                            <div class=""form-group has-feedback has-success"">
                                                <div class=""input-group"">
                                                    <span class=""input-group-addon"">
                                                        <i class=""fa fa-language""></i>
                                                    </span>
                                                    <select class=""form-control"" data-toggle=""tooltip"" id=""select"" style=""cursor: default;"" title=""Select your language preference."">
                                                        ");
                EndContext();
                BeginContext(1964, 24, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8708bdc5aa2e4868aaacdbd5f0dd21ea", async() => {
                    BeginContext(1972, 7, true);
                    WriteLiteral("English");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1988, 307, true);
                WriteLiteral(@"
                                                    </select>
                                                    <span class=""glyphicon form-control-feedback glyphicon-ok"" id=""splang""></span>
                                                </div>
                                            </div>

");
                EndContext();
                BeginContext(2361, 1065, true);
                WriteLiteral(@"                                            <div class=""form-group has-feedback"" id=""fgname"">
                                                <label for=""loginname"">User ID</label>
                                                <div class=""input-group"">
                                                    <span class=""input-group-addon"">
                                                        <i class=""fa fa-user""></i>
                                                    </span>
                                                    <input type=""text"" name=""uName"" id=""uName"" autofocus="""" class=""form-control"" data-toggle=""tooltip"" placeholder=""ABC1XYZ"" title=""Enter your User ID (Workstation&nbsp;ID)"" />
                                                    <span class=""glyphicon form-control-feedback"" id=""spname""></span>
                                                </div>
                                                <div class=""help-block collapse"" id=""msgname"" role=""alert"">&nbsp;</div>
             ");
                WriteLiteral("                               </div>\r\n\r\n");
                EndContext();
                BeginContext(3492, 1029, true);
                WriteLiteral(@"                                            <div class=""form-group has-feedback"" id=""fgpass"">
                                                <label for=""password"">Password</label>
                                                <div class=""input-group"">
                                                    <span class=""input-group-addon"">
                                                        <i class=""fa fa-key""></i>
                                                    </span>
                                                    <input type=""text"" name=""pass"" id=""pass"" class=""form-control"" data-toggle=""tooltip"" placeholder=""Password"" title=""Enter your Password"" />
                                                    <span class=""glyphicon form-control-feedback"" id=""sppass""></span>
                                                </div>
                                                <div class=""help-block collapse"" id=""msgpass"" role=""alert"">&nbsp;</div>
                                            </div");
                WriteLiteral(">\r\n\r\n");
                EndContext();
                BeginContext(4587, 425, true);
                WriteLiteral(@"                                            <div class=""form-group"">
                                                <button class=""btn btn-lg btn-primary btn-block"" id=""sbtn"" type=""submit"">Submit</button>
                                            </div>
                                        </div>
                                    </div>
                                </fieldset>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5019, 244, true);
            WriteLiteral("\r\n                        </section>\r\n                    </div>\r\n\r\n                    <div class=\"panel-footer\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-xs-12\">\r\n                                ");
            EndContext();
            BeginContext(5263, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53eddc86ec4e4396bf73c725c811def3", async() => {
                BeginContext(5322, 22, true);
                WriteLiteral("Register as a new user");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5348, 308, true);
            WriteLiteral(@"<br/>
                                <a href=""#"" onclick=""javascript:window.open('HelpInstructions.jsp');return false;"">Sign in Help</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            EndContext();
#line 93 "C:\Users\SHX8RKD\source\repos\SimpleLogin\SimpleLogin\Views\Home\Login.cshtml"
}

#line default
#line hidden
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
