#pragma checksum "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2878c17c3716366d8dfb8b474fd120c2f26feccc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_TechnicPage), @"mvc.1.0.view", @"/Views/Account/TechnicPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2878c17c3716366d8dfb8b474fd120c2f26feccc", @"/Views/Account/TechnicPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"567306d9ff0a7622502f3b67b79895274b91dc3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_TechnicPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Technic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
  
    ViewData["Title"] = "TechnicPage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<main class=""my-form m-5"">
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
#line 18 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
                                                       Write(SharedLocalizer["Technics"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@":</h3>
                                </div>
                            </div>
                        </div>
                        <div class="" panel-body"">
                            <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <label>");
#nullable restore
#line 26 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
                                          Write(SharedLocalizer["AutoNumber"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                                    </div>\r\n                                    <div class=\"col-md-6\">\r\n                                        <p>");
#nullable restore
#line 29 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
                                      Write(Model.AutoNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-md-6\">\r\n                                        <label>");
#nullable restore
#line 34 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
                                          Write(SharedLocalizer["TechnicData"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                                    </div>\r\n                                    <div class=\"col-md-6\">\r\n                                        <p>");
#nullable restore
#line 37 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
                                      Write(Model.YearOfCarManufacture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-md-6\">\r\n                                        <label>");
#nullable restore
#line 42 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
                                          Write(SharedLocalizer["EngineVolume"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                                    </div>\r\n                                    <div class=\"col-md-6\">\r\n                                        <p>");
#nullable restore
#line 45 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
                                      Write(Model.EngineVolume);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-md-6\">\r\n                                        <label>");
#nullable restore
#line 50 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
                                          Write(SharedLocalizer["TechnicType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                                    </div>\r\n                                    <div class=\"col-md-6\">\r\n                                        <p>");
#nullable restore
#line 53 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
                                      Write(Model.TechnicType.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-md-6\">\r\n                                        <label>");
#nullable restore
#line 58 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
                                          Write(SharedLocalizer["EcoStandart"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                                    </div>\r\n                                    <div class=\"col-md-6\">\r\n                                        <p>");
#nullable restore
#line 61 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
                                      Write(Model.TechnicType.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>   \r\n                                <div class=\"row\">\r\n                                    <div class=\"col-md-6\">\r\n                                        <label>");
#nullable restore
#line 66 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
                                          Write(SharedLocalizer["Fuel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                                    </div>\r\n                                    <div class=\"col-md-6\">\r\n                                        <p>");
#nullable restore
#line 69 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
                                      Write(Model.TechnicType.Fuel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-md-6\">\r\n                                        <label>");
#nullable restore
#line 74 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
                                          Write(SharedLocalizer["Estimated Penalty Points"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                                    </div>\r\n                                    <div class=\"col-md-6\">\r\n                                        <p>");
#nullable restore
#line 77 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
                                      Write(Model.SizeFine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <div>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 4228, "\"", 4274, 1);
#nullable restore
#line 82 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
WriteAttributeValue("", 4235, Url.Action("ViewAllTechnic","Account"), 4235, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 82 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\TechnicPage.cshtml"
                                                                             Write(SharedLocalizer["Back"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Technic> Html { get; private set; }
    }
}
#pragma warning restore 1591
