#pragma checksum "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllSensorType.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75acc3887364a7acdf0ea283781034b1af9c2e9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ViewAllSensorType), @"mvc.1.0.view", @"/Views/Admin/ViewAllSensorType.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75acc3887364a7acdf0ea283781034b1af9c2e9f", @"/Views/Admin/ViewAllSensorType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37113bf3b6086b461ca53532fbc2cec3440875cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ViewAllSensorType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SensorType>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllSensorType.cshtml"
  
    ViewData["Title"] = "ViewAllSensorType";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewAllSensorType</h1>\r\n<br />\r\n<a");
            BeginWriteAttribute("href", " href=\'", 125, "\'", 172, 1);
#nullable restore
#line 8 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllSensorType.cshtml"
WriteAttributeValue("", 132, Url.Action("AddSensorTypePage","Admin"), 132, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"link__dish\">Add Sensor Type</a>\r\n<br />\r\n");
#nullable restore
#line 10 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllSensorType.cshtml"
 foreach (var sensorType in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <a");
            BeginWriteAttribute("href", " href=\'", 282, "\'", 351, 1);
#nullable restore
#line 13 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllSensorType.cshtml"
WriteAttributeValue("", 289, Url.Action("SensorTypePage","Admin", new{id = sensorType.Id}), 289, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"link__dish\">");
#nullable restore
#line 13 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllSensorType.cshtml"
                                                                                               Write(sensorType.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\'", 404, "\'", 474, 1);
#nullable restore
#line 14 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllSensorType.cshtml"
WriteAttributeValue("", 411, Url.Action("SensorTypeRemove","Admin",new{id = sensorType.Id}), 411, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"link__dish\">Delete</a>\r\n    </div>\r\n");
#nullable restore
#line 16 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllSensorType.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\'", 528, "\'", 563, 1);
#nullable restore
#line 19 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Admin\ViewAllSensorType.cshtml"
WriteAttributeValue("", 535, Url.Action("Index","Admin"), 535, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"back__list\">Back</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SensorType>> Html { get; private set; }
    }
}
#pragma warning restore 1591
