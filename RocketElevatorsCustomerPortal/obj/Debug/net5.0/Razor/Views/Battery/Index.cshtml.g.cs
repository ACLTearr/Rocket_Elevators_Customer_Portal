#pragma checksum "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Battery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ad38d02769ad5467d2ea6bd50fa9f68fd6da8ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Battery_Index), @"mvc.1.0.view", @"/Views/Battery/Index.cshtml")]
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
#line 1 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\_ViewImports.cshtml"
using RocketElevatorsCustomerPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\_ViewImports.cshtml"
using RocketElevatorsCustomerPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ad38d02769ad5467d2ea6bd50fa9f68fd6da8ea", @"/Views/Battery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48c42c1a4ab65cf79bfd42f9f01049429aa4f870", @"/Views/_ViewImports.cshtml")]
    public class Views_Battery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Battery\Index.cshtml"
  
    ViewData["Title"] = "Batteries Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Your Batteries</h1>
</div>

<table class=""table table-sm table-striped table-bordered m-2"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Building Type</th>
            <th>Status</th>
            <th>Commission Date</th>
            <th>Last Inspection</th>
            <th>Operation Certificate</th>
            <th>Battery Info</th>
            <th>Notes</th>
            <th>Created On</th>
            <th>Last Updated</th>
            <th>Employee Id</th>
            <th>Building Id</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Battery\Index.cshtml"
         foreach (var b in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 30 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Battery\Index.cshtml"
           Write(b.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Battery\Index.cshtml"
           Write(b.building_type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Battery\Index.cshtml"
           Write(b.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Battery\Index.cshtml"
           Write(b.date_of_commissioning);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Battery\Index.cshtml"
           Write(b.date_of_last_inspection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Battery\Index.cshtml"
           Write(b.certificate_of_operations);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Battery\Index.cshtml"
           Write(b.information);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Battery\Index.cshtml"
           Write(b.notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Battery\Index.cshtml"
           Write(b.created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Battery\Index.cshtml"
           Write(b.updated_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Battery\Index.cshtml"
           Write(b.employee_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Battery\Index.cshtml"
           Write(b.building_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 43 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Battery\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
