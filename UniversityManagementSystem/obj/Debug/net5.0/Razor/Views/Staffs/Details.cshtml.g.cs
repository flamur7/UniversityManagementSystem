#pragma checksum "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eeb740fd463ceee36a0ff3254d0cd1ead772457"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staffs_Details), @"mvc.1.0.view", @"/Views/Staffs/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\_ViewImports.cshtml"
using UniversityManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\_ViewImports.cshtml"
using UniversityManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eeb740fd463ceee36a0ff3254d0cd1ead772457", @"/Views/Staffs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0123509fc62527eb758075da0c17b9d9df07350b", @"/Views/_ViewImports.cshtml")]
    public class Views_Staffs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityManagementSystem.Models.Staff>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background:color;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("290px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 5px;border: 1px solid #efefef"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"modal-body\">\r\n   <h2>Hi I???m <b>");
#nullable restore
#line 10 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Details.cshtml"
            Write(Html.DisplayFor(model => model.StaffName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> <br /></h2>\r\n   <h5>I\'m very happy to join this university, I will do my best here are some of my information for you:</h5><br />\r\n   \r\n   <h5>My Role is: <b><u>");
#nullable restore
#line 13 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Details.cshtml"
                    Write(Html.DisplayFor(model => model.StaffRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></b></h5>\r\n   \r\n   <h5>My Full Name is: <b><u>");
#nullable restore
#line 15 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Details.cshtml"
                         Write(Html.DisplayFor(model => model.StaffName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></b></h5>\r\n   \r\n   <h5>I was working here since: <b><u>");
#nullable restore
#line 17 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Details.cshtml"
                                  Write(Html.DisplayFor(model => model.StaredJob));

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></b></h5>\r\n   <br />\r\n   <h6>For more information please click the button \"More Information\". Thank you for reading my information.</h6>\r\n   <br />\r\n   <h5>My Contact</h5>\r\n    <h6><b>Email: ");
#nullable restore
#line 22 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Details.cshtml"
             Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h6>\r\n    <h6><b>Phone: +383 ");
#nullable restore
#line 23 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Details.cshtml"
                  Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h6>\r\n</div>\r\n<br />\r\n<br />\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1eeb740fd463ceee36a0ff3254d0cd1ead7724579630", async() => {
                WriteLiteral("&nbsp;Back&nbsp;");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<br />
<br />
<hr />
<div class=""container"">
    <div class=""row d-flex justify-content-center mt-200""> <button type=""button"" class=""btn btn-dark"" data-toggle=""modal"" data-target=""#exampleModal""> Read More + </button> </div> <!-- Modal -->
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-lg modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"" style=""background: black; color: white;"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">More Information</h5> <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"" style=""color:white""> <span aria-hidden=""true"">&times;</span> </button>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1eeb740fd463ceee36a0ff3254d0cd1ead77245711882", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1eeb740fd463ceee36a0ff3254d0cd1ead77245712161", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 43 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <div class=""modal-body"">
                        <div id=""smartwizard"">
                            <div class=""mt-4"" >
                                <div id=""step-1"">
                                    <div class=""row"">
                                        </div>
                                    </div>
                                    <div class=""row mt-3"">
                                        <div class=""col-md-6""> <dt class = ""col-sm-2"" style=""font-size: 20px; font-family: serif;""> ");
#nullable restore
#line 52 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Details.cshtml"
                                                                                                                               Write(Html.DisplayNameFor(model => model.Nationality));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </dt>\r\n                                                                <dd class = \"col-sm-10\" style=\"font-size: 17px; font-family: serif;\"> ");
#nullable restore
#line 53 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Details.cshtml"
                                                                                                                                 Write(Html.DisplayFor(model => model.Nationality.NationalityName));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </dd>   \r\n                                        </div>\r\n                                        <div class=\"col-md-6\"> <dt class = \"col-sm-2\" style=\"font-size: 20px; font-family: serif;\">");
#nullable restore
#line 55 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Details.cshtml"
                                                                                                                              Write(Html.DisplayNameFor(model => model.Branch));

#line default
#line hidden
#nullable disable
                WriteLiteral("</dt>\r\n                                                                <dd class = \"col-sm-10\" style=\"font-size: 17px; font-family: serif;\">");
#nullable restore
#line 56 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Details.cshtml"
                                                                                                                                Write(Html.DisplayFor(model => model.Branch.BranchName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</dd>    
                                        </div>
                                    </div>
                                </div>
                                <div id=""step-2"">
                                    <div class=""row"" style=""margin-top: 20px;""><br />
                                        <div class=""col-md-6""> <dt class = ""col-sm-2"" style=""font-size: 20px; font-family: serif;"">");
#nullable restore
#line 62 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Details.cshtml"
                                                                                                                              Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</dt>\r\n                                                                <dd class = \"col-sm-10\" style=\"font-size: 17px; font-family: serif;\">");
#nullable restore
#line 63 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Details.cshtml"
                                                                                                                                Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</dd>  \r\n                                    </div>\r\n                                    <div class=\"row mt-3\">\r\n                                        <div class=\"col-md-6\"> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1eeb740fd463ceee36a0ff3254d0cd1ead77245718115", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4120, "~/", 4120, 2, true);
#nullable restore
#line 66 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Details.cshtml"
AddHtmlAttributeValue("", 4122, Model.Image, 4122, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 79 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Details.cshtml"
      
    await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityManagementSystem.Models.Staff> Html { get; private set; }
    }
}
#pragma warning restore 1591
