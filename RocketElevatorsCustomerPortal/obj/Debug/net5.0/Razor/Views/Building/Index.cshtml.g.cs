#pragma checksum "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Building\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "849dc1f864e37012cdc6da2f59bd4a1ec9dd0e1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Building_Index), @"mvc.1.0.view", @"/Views/Building/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"849dc1f864e37012cdc6da2f59bd4a1ec9dd0e1b", @"/Views/Building/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48c42c1a4ab65cf79bfd42f9f01049429aa4f870", @"/Views/_ViewImports.cshtml")]
    public class Views_Building_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Building>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Building\Index.cshtml"
  
    ViewData["Title"] = "Buildings";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Your Buildings</h1>
</div>

<table class=""table table-sm table-striped table-bordered m-2"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Building Administrator</th>
            <th>Building Administrator Email</th>
            <th>Building Administrator Phone Number</th>
            <th>Building Technical Contact</th>
            <th>Technical Contact Email</th>
            <th>Technical Contact Phone Number</th>
            <th>Created On</th>
            <th>Last Updated</th>
            <th>Customer Id</th>
            <th>Address Id</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Building\Index.cshtml"
         foreach (var b in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 30 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Building\Index.cshtml"
           Write(b.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Building\Index.cshtml"
           Write(b.full_name_of_the_building_administrator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Building\Index.cshtml"
           Write(b.email_of_the_administrator_of_the_building);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Building\Index.cshtml"
           Write(b.phone_number_of_the_building_administrator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Building\Index.cshtml"
           Write(b.full_name_of_the_technical_contact_for_the_building);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Building\Index.cshtml"
           Write(b.technical_contact_email_for_the_building);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Building\Index.cshtml"
           Write(b.technical_contact_phone_for_the_building);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Building\Index.cshtml"
           Write(b.created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Building\Index.cshtml"
           Write(b.updated_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Building\Index.cshtml"
           Write(b.customer_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Building\Index.cshtml"
           Write(b.address_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Building\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Building>> Html { get; private set; }
    }
}
#pragma warning restore 1591
