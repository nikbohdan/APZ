#pragma checksum "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99bfc90e3795b71bcd507169e698e9b7f5cfb694"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99bfc90e3795b71bcd507169e698e9b7f5cfb694", @"/Views/Account/PlacePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"567306d9ff0a7622502f3b67b79895274b91dc3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_PlacePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Place>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
  
    ViewData["Title"] = "PlacePage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>PlacePage</h1>\r\n<p>Адресс:</p>\r\n<p>");
#nullable restore
#line 8 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Тип жилья:</p>\r\n<p>");
#nullable restore
#line 10 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
Write(Model.PlaceType.HousingType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Вид отопления:</p>\r\n<p>");
#nullable restore
#line 12 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
Write(Model.PlaceType.EcoType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Предусмотренный размер штрафных баллов:</p>\r\n<p>");
#nullable restore
#line 14 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
Write(Model.PlaceType.SizeFine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n<a");
            BeginWriteAttribute("href", " href=\'", 324, "\'", 368, 1);
#nullable restore
#line 16 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\PlacePage.cshtml"
WriteAttributeValue("", 331, Url.Action("ViewAllPlace","Account"), 331, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"back__list\">Back to List</a>");
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
