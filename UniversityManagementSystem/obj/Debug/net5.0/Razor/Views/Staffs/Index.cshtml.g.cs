#pragma checksum "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59e27bb676e5f03b610c0240872d036a839ab44d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staffs_Index), @"mvc.1.0.view", @"/Views/Staffs/Index.cshtml")]
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
#line 2 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Index.cshtml"
using UniversityManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e27bb676e5f03b610c0240872d036a839ab44d", @"/Views/Staffs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0123509fc62527eb758075da0c17b9d9df07350b", @"/Views/_ViewImports.cshtml")]
    public class Views_Staffs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UniversityManagementSystem.Models.Staff>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h4 class=\"titulli1\">Staff List</h4>\r\n    </div>\r\n");
            WriteLiteral("</div>\r\n<br />\r\n\r\n<div id=\"view-all\">\r\n    ");
#nullable restore
#line 22 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Index.cshtml"
Write(await Html.PartialAsync("_StaffsTablePartialView", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"//cdn.jsdelivr.net/npm/alertifyjs@1.11.2/build/alertify.min.js\"></script>\r\n    <script type=\"text/javascript\">\r\n        $(function(){\r\n            var save = \'");
#nullable restore
#line 30 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Index.cshtml"
                   Write(TempData["save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            if(save!=\'\') {\r\n                alertify.success(save);\r\n            }\r\n            var edit = \'");
#nullable restore
#line 34 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Index.cshtml"
                   Write(TempData["edit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            if(edit!=\'\') {\r\n                alertify.success(edit);\r\n            }\r\n            var del = \'");
#nullable restore
#line 38 "C:\Users\Admin\source\repos\UniversityManagementSystem\UniversityManagementSystem\Views\Staffs\Index.cshtml"
                  Write(TempData["delete"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            if (del!=\'\') {\r\n                alertify.error(del);\r\n            }\r\n        })\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UniversityManagementSystem.Models.Staff>> Html { get; private set; }
    }
}
#pragma warning restore 1591
