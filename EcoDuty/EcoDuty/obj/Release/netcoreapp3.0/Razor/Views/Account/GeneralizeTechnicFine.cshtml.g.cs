#pragma checksum "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\GeneralizeTechnicFine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f19c8542990161f9088ccafe99345c1031460a37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_GeneralizeTechnicFine), @"mvc.1.0.view", @"/Views/Account/GeneralizeTechnicFine.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f19c8542990161f9088ccafe99345c1031460a37", @"/Views/Account/GeneralizeTechnicFine.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37113bf3b6086b461ca53532fbc2cec3440875cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_GeneralizeTechnicFine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Technic>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\GeneralizeTechnicFine.cshtml"
  
    ViewData["Title"] = "GeneralizeTechnicFine";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GeneralizeTechnicFine</h1>\r\n\r\n");
#nullable restore
#line 8 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\GeneralizeTechnicFine.cshtml"
 foreach (var technic in Model)
{
    if (technic.AutoNumber != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <br />\r\n            <a");
            BeginWriteAttribute("href", " href=\'", 251, "\'", 316, 1);
#nullable restore
#line 14 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\GeneralizeTechnicFine.cshtml"
WriteAttributeValue("", 258, Url.Action("TechnicPage","Account", new{id = technic.Id}), 258, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"link__dish\">\r\n                <p>Соответствия нормам экологических стандартов</p>\r\n                <p>регистрационный номер техники ");
#nullable restore
#line 16 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\GeneralizeTechnicFine.cshtml"
                                            Write(technic.AutoNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Количество штрафных баллов ");
#nullable restore
#line 17 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\GeneralizeTechnicFine.cshtml"
                                         Write(technic.SizeFine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </a>\r\n            <br />\r\n        </div>\r\n");
#nullable restore
#line 21 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\GeneralizeTechnicFine.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <br />\r\n            <a");
            BeginWriteAttribute("href", " href=\'", 678, "\'", 743, 1);
#nullable restore
#line 26 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\GeneralizeTechnicFine.cshtml"
WriteAttributeValue("", 685, Url.Action("TechnicPage","Account", new{id = technic.Id}), 685, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"link__dish\">\r\n                <p>Соответствия нормам экологических стандартов</p>\r\n                <p>техника была удаленна</p>\r\n                <p>Количество штрафных баллов ");
#nullable restore
#line 29 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\GeneralizeTechnicFine.cshtml"
                                         Write(technic.SizeFine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </a>\r\n            <br />\r\n        </div>\r\n");
#nullable restore
#line 33 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\GeneralizeTechnicFine.cshtml"
    }

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Technic>> Html { get; private set; }
    }
}
#pragma warning restore 1591
