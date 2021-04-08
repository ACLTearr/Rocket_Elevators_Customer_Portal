#pragma checksum "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27f56486aee21419a259ca7769d305fa13f8aca2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27f56486aee21419a259ca7769d305fa13f8aca2", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48c42c1a4ab65cf79bfd42f9f01049429aa4f870", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Customer Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
</div>

<table class=""table table-sm table-striped table-bordered m-2"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Creation Date</th>
            <th>Company Name</th>
            <th>Company Contact</th>
            <th>Company Contact Phone Number</th>
            <th>Company Contact Email</th>
            <th>Company Description</th>
            <th>Technical Service Authority</th>
            <th>Technical Service Authority Phone Number</th>
            <th>Technical Service Authority Email</th>
            <th>Created On</th>
            <th>Last Updated</th>
            <th>User Id</th>
            <th>Address Id</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml"
         foreach (var c in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 32 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml"
           Write(c.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml"
           Write(c.customers_creation_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml"
           Write(c.company_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml"
           Write(c.full_name_of_company_contact);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml"
           Write(c.company_contact_phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml"
           Write(c.email_of_company_contact);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml"
           Write(c.company_description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml"
           Write(c.full_name_of_service_technical_authority);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml"
           Write(c.technical_authority_phone_for_service_);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml"
           Write(c.technical_manager_email_for_service);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 42 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml"
           Write(c.created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml"
           Write(c.updated_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml"
           Write(c.user_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml"
           Write(c.address_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\codeboxx\week-11\RocketElevatorsCustomerPortal\RocketElevatorsCustomerPortal\Views\Customer\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
