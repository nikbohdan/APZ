#pragma checksum "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f75d4437e51201a6e4144b1f774105b6490ae295"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SensorPage), @"mvc.1.0.view", @"/Views/Account/SensorPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75d4437e51201a6e4144b1f774105b6490ae295", @"/Views/Account/SensorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"105f2e1a8c56cc74714980333b4ec2782b5f8954", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SensorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sensor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
  
    ViewData["Title"] = "SensorPage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>SensorPage</h1>\r\n<p>Серийный номер:</p>\r\n<p>");
#nullable restore
#line 8 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
Write(Model.SerialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Тип сенсора:</p>\r\n<p>");
#nullable restore
#line 10 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
Write(Model.SensorType.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 11 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
 switch (@Model.SensorType.ResType)
{
    case "Int":

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Экологический стандарт:</p>\r\n        <p>");
#nullable restore
#line 15 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
      Write(Model.SensorType.NormalInt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Текущий показатель:</p>\r\n        <p>");
#nullable restore
#line 17 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
      Write(Model.CurrentInt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 18 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
        break;
    case "Bool":

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Экологический стандарт:</p>\r\n        <p>");
#nullable restore
#line 21 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
      Write(Model.SensorType.NormalBool);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Текущий показатель:</p>\r\n        <p>");
#nullable restore
#line 23 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
      Write(Model.CurrentBool);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 24 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
        break;
    case "String":

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Экологический стандарт:</p>\r\n        <p>");
#nullable restore
#line 27 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
      Write(Model.SensorType.NormalString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Текущий показатель:</p>\r\n        <p>");
#nullable restore
#line 29 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
      Write(Model.CurrentString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 30 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
        break;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Предусмотренный размер штрафных баллов:</p>\r\n<p>");
#nullable restore
#line 33 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
Write(Model.SensorType.SizeFine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n<p>Fines:</p>\r\n<br />\r\n");
#nullable restore
#line 37 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
 foreach (var fine in Model.Fines)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <p>Описание:</p>\r\n        <p>");
#nullable restore
#line 41 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
      Write(fine.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Дата:</p>\r\n        <p>");
#nullable restore
#line 43 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
      Write(fine.DateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Размер штрафных баллов:</p>\r\n        <p>");
#nullable restore
#line 45 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
      Write(fine.SizeFine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 47 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<a");
            BeginWriteAttribute("href", " href=\'", 1179, "\'", 1224, 1);
#nullable restore
#line 50 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\SensorPage.cshtml"
WriteAttributeValue("", 1186, Url.Action("ViewAllSensor","Account"), 1186, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"back__list\">Back to List</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sensor> Html { get; private set; }
    }
}
#pragma warning restore 1591
