#pragma checksum "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8bc3e6bc9dd3ac5bd090e70e7294840c9aed87f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ViewAllTechnicType), @"mvc.1.0.view", @"/Views/Admin/ViewAllTechnicType.cshtml")]
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
#line 1 "D:\Github\APZ\EcoDuty\EcoDuty\Views\_ViewImports.cshtml"
using EcoDuty;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Github\APZ\EcoDuty\EcoDuty\Views\_ViewImports.cshtml"
using EcoDuty.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Github\APZ\EcoDuty\EcoDuty\Views\_ViewImports.cshtml"
using BusinessLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Github\APZ\EcoDuty\EcoDuty\Views\_ViewImports.cshtml"
using DataLayer.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Github\APZ\EcoDuty\EcoDuty\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8bc3e6bc9dd3ac5bd090e70e7294840c9aed87f", @"/Views/Admin/ViewAllTechnicType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"567306d9ff0a7622502f3b67b79895274b91dc3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ViewAllTechnicType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TechnicType>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
  
    ViewData["Title"] = "ViewAllTechnicType";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>ViewAllTechnicType</h1>
<main class=""my-form"">
    <div class=""cotainer"">
        <div class=""row justify-content-center"">
            <div class=""col-md-8"">
                <div class=""card"">
                    <div class=""panel panel-default panel-table"">
                        <div class=""panel-heading"">
                            <div class=""row"">
                                <div class=""col col-xs-6"">
                                    <h3 class=""panel-title"">");
#nullable restore
#line 16 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
                                                       Write(Localizer["Technics"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                </div>\r\n                                <div class=\"col col-xs-6 text-right\">\r\n                                    <button type=\"button\" class=\"btn btn-sm btn-primary btn-create\"");
            BeginWriteAttribute("onclick", "\r\n                                            onclick=\"", 818, "\"", 930, 3);
            WriteAttributeValue("", 873, "location.href=\'", 873, 15, true);
#nullable restore
#line 20 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
WriteAttributeValue("", 888, Url.Action("AddTechnicTypePage","Admin"), 888, 41, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 929, "\'", 929, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 21 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
                                   Write(Localizer["Create New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </button>
                                </div>
                            </div>
                        </div>
                        <div class=""panel-body"">
                            <table class=""table table-striped table-bordered table-list"">
                                <thead>
                                    <tr>
                                        <th style=""width: 20%""><em class=""fa fa-cog""></em></th>
                                        <th>");
#nullable restore
#line 31 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
                                       Write(SharedLocalizer["TechnicType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 32 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
                                       Write(SharedLocalizer["Class of technic"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 36 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
                                     foreach (var technicType in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td align=\"center\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\'", 2044, "\'", 2115, 1);
#nullable restore
#line 40 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
WriteAttributeValue("", 2051, Url.Action("TechnicTypePage","Admin", new{id = technicType.Id}), 2051, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\"><em class=\"fa fa-pencil\"></em></a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\'", 2227, "\'", 2299, 1);
#nullable restore
#line 41 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
WriteAttributeValue("", 2234, Url.Action("TechnicTypeRemove","Admin",new{id = technicType.Id}), 2234, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"><em class=\"fa fa-trash\"></em></a>\r\n                                            </td>\r\n                                            <td>");
#nullable restore
#line 43 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
                                           Write(technicType.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                            <td>");
#nullable restore
#line 44 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
                                           Write(technicType.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 46 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n<br />\r\n<a");
            BeginWriteAttribute("href", " href=\'", 2884, "\'", 2932, 1);
#nullable restore
#line 58 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
WriteAttributeValue("", 2891, Url.Action("AddTechnicTypePage","Admin"), 2891, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"link__dish\">Add Technic Type</a>\r\n<br />\r\n");
#nullable restore
#line 60 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
 foreach (var technicType in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <a");
            BeginWriteAttribute("href", " href=\'", 3044, "\'", 3115, 1);
#nullable restore
#line 63 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
WriteAttributeValue("", 3051, Url.Action("TechnicTypePage","Admin", new{id = technicType.Id}), 3051, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"link__dish\">");
#nullable restore
#line 63 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
                                                                                                 Write(technicType.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 63 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
                                                                                                                   Write(technicType.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\'", 3197, "\'", 3269, 1);
#nullable restore
#line 64 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
WriteAttributeValue("", 3204, Url.Action("TechnicTypeRemove","Admin",new{id = technicType.Id}), 3204, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"link__dish\">Delete</a>\r\n    </div>\r\n");
#nullable restore
#line 66 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a");
            BeginWriteAttribute("href", " href=\'", 3321, "\'", 3356, 1);
#nullable restore
#line 68 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllTechnicType.cshtml"
WriteAttributeValue("", 3328, Url.Action("Index","Admin"), 3328, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"back__list\">Back</a>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResource> SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TechnicType>> Html { get; private set; }
    }
}
#pragma warning restore 1591
