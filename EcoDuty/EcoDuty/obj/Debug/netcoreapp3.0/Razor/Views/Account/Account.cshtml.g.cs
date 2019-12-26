#pragma checksum "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02540d66b7c2cb5cb12a1256946cdb6deeaa03e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Account), @"mvc.1.0.view", @"/Views/Account/Account.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02540d66b7c2cb5cb12a1256946cdb6deeaa03e3", @"/Views/Account/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"567306d9ff0a7622502f3b67b79895274b91dc3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
  
    ViewData["Title"] = "Account";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    /*body {
        background: -webkit-linear-gradient(left, #6057eb, #00c6ff);
    }*/

    .emp-profile {
        padding: 3%;
        margin-top: 3%;
        margin-bottom: 3%;
        border-radius: 0.5rem;
        background: #fff;
    }

    .profile-img {
        text-align: center;
    }

        .profile-img img {
            width: 70%;
            height: 100%;
        }

        .profile-img .file {
            position: relative;
            overflow: hidden;
            margin-top: -20%;
            width: 70%;
            border: none;
            border-radius: 0;
            font-size: 15px;
            background: #212529b8;
        }

            .profile-img .file input {
                position: absolute;
                opacity: 0;
                right: 0;
                top: 0;
            }

    .profile-head h5 {
        color: #333;
    }

    .profile-head h6 {
        color: #0062cc;
    }

    .profile-edit-btn {
    ");
            WriteLiteral(@"    border: none;
        border-radius: 1.5rem;
        width: 70%;
        padding: 2%;
        font-weight: 600;
        color: #6c757d;
        cursor: pointer;
    }

    .proile-rating {
        font-size: 12px;
        color: #818182;
        margin-top: 5%;
    }

        .proile-rating span {
            color: #495057;
            font-size: 15px;
            font-weight: 600;
        }

    .profile-head .nav-tabs {
        margin-bottom: 5%;
    }

        .profile-head .nav-tabs .nav-link {
            font-weight: 600;
            border: none;
        }

            .profile-head .nav-tabs .nav-link.active {
                border: none;
                border-bottom: 2px solid #0062cc;
            }

    .profile-work {
        padding: 14%;
        margin-top: -15%;
    }

        .profile-work p {
            font-size: 12px;
            color: #818182;
            font-weight: 600;
            margin-top: 10%;
        }

        .profile-work a");
            WriteLiteral(@" {
            text-decoration: none;
            color: #495057;
            font-weight: 600;
            font-size: 14px;
        }

        .profile-work ul {
            list-style: none;
        }

    .profile-tab label {
        font-weight: 600;
    }

    .profile-tab p {
        font-weight: 600;
        color: #0062cc;
    }
</style>


<br />
<br />
<br />
<br />

<div class=""container emp-profile"">
    <div class=""row"">
        <div class=""col-md-4"">
");
#nullable restore
#line 132 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
             if (User.Identity.Name == Model.Passport)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"button\" class=\"profile-edit-btn\" name=\"btnAddMore\"");
            BeginWriteAttribute("value", " value=", 2757, "", 2790, 1);
#nullable restore
#line 134 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
WriteAttributeValue("", 2764, Localizer["Edit Profile"], 2764, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2790, "\"", 2856, 3);
            WriteAttributeValue("", 2800, "location.href=\'", 2800, 15, true);
#nullable restore
#line 134 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
WriteAttributeValue("", 2815, Url.Action("ChangeUserData", "Account"), 2815, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2855, "\'", 2855, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 135 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-6\">\r\n            <div class=\"profile-head\">\r\n                <h5>\r\n                    ");
#nullable restore
#line 140 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
               Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 140 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h5>\r\n\r\n");
            WriteLiteral(@"
                <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                    <li class=""nav-item"">
                        <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">");
#nullable restore
#line 149 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                                                                                                                                                Write(Localizer["About"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\" id=\"profile-tab\" data-toggle=\"tab\" href=\"#profile\" role=\"tab\" aria-controls=\"profile\" aria-selected=\"false\">");
#nullable restore
#line 152 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                                                                                                                                                   Write(Localizer["All fines"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">   \r\n        <div class=\"col-md-4\">\r\n            <div class=\"profile-work\">\r\n                <p>");
#nullable restore
#line 161 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
              Write(Localizer["My property"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</p>\r\n                <a");
            BeginWriteAttribute("href", " href=\'", 3968, "\'", 4012, 1);
#nullable restore
#line 162 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
WriteAttributeValue("", 3975, Url.Action("ViewAllPlace","Account"), 3975, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"link__dish\">");
#nullable restore
#line 162 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                                                                              Write(Localizer["Places"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                <br />\r\n                <br />\r\n                <a");
            BeginWriteAttribute("href", " href=\'", 4125, "\'", 4171, 1);
#nullable restore
#line 165 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
WriteAttributeValue("", 4132, Url.Action("ViewAllTechnic","Account"), 4132, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"link__dish\">");
#nullable restore
#line 165 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                                                                                Write(Localizer["Technics"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                <br />\r\n                <br />\r\n                <a");
            BeginWriteAttribute("href", " href=\'", 4286, "\'", 4331, 1);
#nullable restore
#line 168 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
WriteAttributeValue("", 4293, Url.Action("ViewAllSensor","Account"), 4293, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"link__dish\">");
#nullable restore
#line 168 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                                                                               Write(Localizer["Sensors"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
            </div>
        </div>
        <div class=""col-md-8"">
            <div class=""tab-content profile-tab"" id=""myTabContent"">
                <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>");
#nullable restore
#line 176 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                              Write(Localizer["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
#nullable restore
#line 179 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                          Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 179 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            <label>");
#nullable restore
#line 184 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                              Write(Localizer["Amount of penalty points"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
#nullable restore
#line 187 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                          Write(Model.SumSizeFine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            <label>");
#nullable restore
#line 192 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                              Write(Localizer["Passport number"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
#nullable restore
#line 195 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                          Write(Model.Passport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            <label>");
#nullable restore
#line 200 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                              Write(Localizer["Email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
#nullable restore
#line 203 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                          Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            <label>");
#nullable restore
#line 208 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                              Write(Localizer["Tax Identity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
#nullable restore
#line 211 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                          Write(Model.TaxIdentity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            <label>");
#nullable restore
#line 216 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                              Write(Localizer["City"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
#nullable restore
#line 219 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                          Write(Model.City.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
                <div class=""tab-pane fade"" id=""profile"" role=""tabpanel"" aria-labelledby=""profile-tab"">
                    <div class=""m-3"">
                        <div class=""col-md-6"">
                            <button type=""button"" class=""btn btn-primary btn-lg btn-block""");
            BeginWriteAttribute("onclick", "\r\n                                    onclick=\"", 7039, "\"", 7177, 3);
            WriteAttributeValue("", 7086, "location.href=\'", 7086, 15, true);
#nullable restore
#line 227 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
WriteAttributeValue("", 7101, Url.Action("GeneralizeTechnicFine","Account", new{name = @Model.Passport}), 7101, 75, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7176, "\'", 7176, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
#nullable restore
#line 228 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                           Write(Localizer["All Technics Fines"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </button>
                        </div>
                    </div>
                    <div class=""m-3"">
                        <div class=""col-md-6"">
                            <button type=""button"" class=""btn btn-primary btn-lg btn-block""");
            BeginWriteAttribute("onclick", "\r\n                                    onclick=\"", 7523, "\"", 7659, 3);
            WriteAttributeValue("", 7570, "location.href=\'", 7570, 15, true);
#nullable restore
#line 235 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
WriteAttributeValue("", 7585, Url.Action("GeneralizePlaceFine","Account", new{name = @Model.Passport}), 7585, 73, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7658, "\'", 7658, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
#nullable restore
#line 236 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                           Write(Localizer["All Places Fines"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </button>
                        </div>
                    </div>
                    <div class=""m-3"">
                        <div class=""col-md-6"">
                            <button type=""button"" class=""btn btn-primary btn-lg btn-block""");
            BeginWriteAttribute("onclick", "\r\n                                    onclick=\"", 8003, "\"", 8140, 3);
            WriteAttributeValue("", 8050, "location.href=\'", 8050, 15, true);
#nullable restore
#line 243 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
WriteAttributeValue("", 8065, Url.Action("GeneralizeSensorFine","Account", new{name = @Model.Passport}), 8065, 74, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8139, "\'", 8139, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
#nullable restore
#line 244 "D:\Github\APZ\EcoDuty\EcoDuty\Views\Account\Account.cshtml"
                           Write(Localizer["All Sensors Fines(IoT)"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
