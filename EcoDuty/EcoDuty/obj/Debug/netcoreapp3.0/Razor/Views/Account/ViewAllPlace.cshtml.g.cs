#pragma checksum "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\ViewAllPlace.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0305557a627ba0869c6b21d6506af1f41d7f4d9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ViewAllPlace), @"mvc.1.0.view", @"/Views/Account/ViewAllPlace.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0305557a627ba0869c6b21d6506af1f41d7f4d9a", @"/Views/Account/ViewAllPlace.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"105f2e1a8c56cc74714980333b4ec2782b5f8954", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ViewAllPlace : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Place>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\ViewAllPlace.cshtml"
  
    ViewData["Title"] = "ViewAllPlace";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewAllPlace</h1>\r\n\r\n<br />\r\n<a");
            BeginWriteAttribute("href", " href=\'", 112, "\'", 156, 1);
#nullable restore
#line 9 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\ViewAllPlace.cshtml"
WriteAttributeValue("", 119, Url.Action("AddPlacePage","Account"), 119, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"back__list\">Add Place</a>\r\n<br />\r\n");
#nullable restore
#line 11 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\ViewAllPlace.cshtml"
 foreach (var place in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <a");
            BeginWriteAttribute("href", " href=\'", 255, "\'", 316, 1);
#nullable restore
#line 14 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\ViewAllPlace.cshtml"
WriteAttributeValue("", 262, Url.Action("PlacePage","Account", new{id = place.Id}), 262, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"link__dish\">");
#nullable restore
#line 14 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\ViewAllPlace.cshtml"
                                                                                       Write(place.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\'", 367, "\'", 429, 1);
#nullable restore
#line 15 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\ViewAllPlace.cshtml"
WriteAttributeValue("", 374, Url.Action("PlaceRemove","Account",new{id = place.Id}), 374, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"link__dish\">Delete</a>\r\n    </div>\r\n");
#nullable restore
#line 17 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\ViewAllPlace.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a");
            BeginWriteAttribute("href", " href=\'", 481, "\'", 519, 1);
#nullable restore
#line 19 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\ViewAllPlace.cshtml"
WriteAttributeValue("", 488, Url.Action("Accunt","Account"), 488, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"back__list\">Back</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Place>> Html { get; private set; }
    }
}
#pragma warning restore 1591
