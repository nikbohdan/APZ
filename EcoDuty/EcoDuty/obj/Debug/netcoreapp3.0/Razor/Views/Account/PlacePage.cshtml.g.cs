#pragma checksum "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fb1598f30573becb4c5474ee764b3bf8643c82f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_PlacePage), @"mvc.1.0.view", @"/Views/Account/PlacePage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fb1598f30573becb4c5474ee764b3bf8643c82f", @"/Views/Account/PlacePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"567306d9ff0a7622502f3b67b79895274b91dc3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_PlacePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Place>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
  
    ViewData["Title"] = "PlacePage";
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
#line 17 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
                                                       Write(Localizer["Places"]);

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
#line 25 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
                                          Write(SharedLocalizer["Address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                                    </div>\r\n                                    <div class=\"col-md-6\">\r\n                                        <p>");
#nullable restore
#line 28 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
                                      Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-md-6\">\r\n                                        <label>");
#nullable restore
#line 33 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
                                          Write(Localizer["Place Type"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                                    </div>\r\n                                    <div class=\"col-md-6\">\r\n                                        <p>");
#nullable restore
#line 36 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
                                      Write(Model.PlaceType.HousingType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-md-6\">\r\n                                        <label>");
#nullable restore
#line 41 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
                                          Write(Localizer["Type of heating"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                                    </div>\r\n                                    <div class=\"col-md-6\">\r\n                                        <p>");
#nullable restore
#line 44 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
                                      Write(Model.PlaceType.EcoType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-md-6\">\r\n                                        <label>");
#nullable restore
#line 49 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
                                          Write(Localizer["Estimated Penalty Points"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                                    </div>\r\n                                    <div class=\"col-md-6\">\r\n                                        <p>");
#nullable restore
#line 52 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
                                      Write(Model.SizeFine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <div>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2812, "\"", 2856, 1);
#nullable restore
#line 57 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
WriteAttributeValue("", 2819, Url.Action("ViewAllPlace","Account"), 2819, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 57 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
                                                                           Write(SharedLocalizer["Back"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Place> Html { get; private set; }
    }
}
#pragma warning restore 1591
