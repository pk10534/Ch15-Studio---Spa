#pragma checksum "C:\Users\pk080\source\repos\New Spa Studio ch15\Ch15 Spa Studio - New\Views\Spa\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7cea364761fb0b646162e5f01b4733d258b485a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Spa_Menu), @"mvc.1.0.view", @"/Views/Spa/Menu.cshtml")]
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
#line 1 "C:\Users\pk080\source\repos\New Spa Studio ch15\Ch15 Spa Studio - New\Views\_ViewImports.cshtml"
using Ch15_Spa_Studio___New;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pk080\source\repos\New Spa Studio ch15\Ch15 Spa Studio - New\Views\_ViewImports.cshtml"
using Ch15_Spa_Studio___New.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7cea364761fb0b646162e5f01b4733d258b485a", @"/Views/Spa/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ba61139be487f7c98beea469132f0b332814d3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Spa_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Fancy Spa</h1>\r\n<div id=\"clientProfile\">\r\n    <h3>Client profile</h3>\r\n</div>\r\n<div id=\"servicesMenu\">\r\n    <h5>Facial Treatments</h5>\r\n    Your ");
#nullable restore
#line 13 "C:\Users\pk080\source\repos\New Spa Studio ch15\Ch15 Spa Studio - New\Views\Spa\Menu.cshtml"
    Write(ViewBag.client.SkinType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" skin type is best suited to the follow facial types:\r\n\r\n    <ul>\r\n");
#nullable restore
#line 16 "C:\Users\pk080\source\repos\New Spa Studio ch15\Ch15 Spa Studio - New\Views\Spa\Menu.cshtml"
         foreach (string facial in ViewBag.client.GetFacials())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 18 "C:\Users\pk080\source\repos\New Spa Studio ch15\Ch15 Spa Studio - New\Views\Spa\Menu.cshtml"
           Write(facial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 19 "C:\Users\pk080\source\repos\New Spa Studio ch15\Ch15 Spa Studio - New\Views\Spa\Menu.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <h5>Nail Services</h5>\r\n");
#nullable restore
#line 22 "C:\Users\pk080\source\repos\New Spa Studio ch15\Ch15 Spa Studio - New\Views\Spa\Menu.cshtml"
     if (ViewBag.client.NailService == "manicure")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Our manicure is a great way to spend 30 minutes of your day! We use shea butter hand cream and the finest gel polish.</p>\r\n");
#nullable restore
#line 25 "C:\Users\pk080\source\repos\New Spa Studio ch15\Ch15 Spa Studio - New\Views\Spa\Menu.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Relax for 45 minutes in pure luxury! Our massage chairs and experienced nail techs are here to get your feet in shape for sandal season!</p>\r\n");
#nullable restore
#line 29 "C:\Users\pk080\source\repos\New Spa Studio ch15\Ch15 Spa Studio - New\Views\Spa\Menu.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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