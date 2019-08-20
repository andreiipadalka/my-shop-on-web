#pragma checksum "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11c2ad89bdc7cd239dc5ad68d46adc6b8f282994"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Detail), @"mvc.1.0.view", @"/Views/Order/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Detail.cshtml", typeof(AspNetCore.Views_Order_Detail))]
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
#line 1 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/_ViewImports.cshtml"
using Microsoft.eShopWeb;

#line default
#line hidden
#line 1 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
using Microsoft.eShopWeb.ViewModels;

#line default
#line hidden
#line 3 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/_ViewImports.cshtml"
using Microsoft.eShopWeb.ViewModels.Account;

#line default
#line hidden
#line 4 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/_ViewImports.cshtml"
using Microsoft.eShopWeb.ViewModels.Manage;

#line default
#line hidden
#line 5 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/_ViewImports.cshtml"
using Infrastructure.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11c2ad89bdc7cd239dc5ad68d46adc6b8f282994", @"/Views/Order/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"871f1400195b809d4df4ea3345169cb05634366b", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
  
    ViewData["Title"] = "My Order History";

#line default
#line hidden
#line 6 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
  
    ViewData["Title"] = "Order Detail";

#line default
#line hidden
            BeginContext(153, 654, true);
            WriteLiteral(@"
<div class=""esh-orders_detail"">
    <div class=""container"">
        <section class=""esh-orders_detail-section"">
            <article class=""esh-orders_detail-titles row"">
                <section class=""esh-orders_detail-title col-xs-3"">Order number</section>
                <section class=""esh-orders_detail-title col-xs-3"">Date</section>
                <section class=""esh-orders_detail-title col-xs-3"">Total</section>
                <section class=""esh-orders_detail-title col-xs-3"">Status</section>
            </article>

            <article class=""esh-orders_detail-items row"">
                <section class=""esh-orders_detail-item col-xs-3"">");
            EndContext();
            BeginContext(808, 17, false);
#line 21 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
                                                            Write(Model.OrderNumber);

#line default
#line hidden
            EndContext();
            BeginContext(825, 76, true);
            WriteLiteral("</section>\n                <section class=\"esh-orders_detail-item col-xs-3\">");
            EndContext();
            BeginContext(902, 15, false);
#line 22 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
                                                            Write(Model.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(917, 77, true);
            WriteLiteral("</section>\n                <section class=\"esh-orders_detail-item col-xs-3\">$");
            EndContext();
            BeginContext(995, 11, false);
#line 23 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
                                                             Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(1006, 77, true);
            WriteLiteral("</section>\n                <section class=\"esh-orders_detail-title col-xs-3\">");
            EndContext();
            BeginContext(1084, 12, false);
#line 24 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
                                                             Write(Model.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1096, 54, true);
            WriteLiteral("</section>\n            </article>\n        </section>\n\n");
            EndContext();
            BeginContext(1573, 354, true);
            WriteLiteral(@"
        <section class=""esh-orders_detail-section"">
            <article class=""esh-orders_detail-titles row"">
                <section class=""esh-orders_detail-title col-xs-12"">Shipping Address</section>
            </article>

            <article class=""esh-orders_detail-items row"">
                <section class=""esh-orders_detail-item col-xs-12"">");
            EndContext();
            BeginContext(1928, 28, false);
#line 44 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
                                                             Write(Model.ShippingAddress.Street);

#line default
#line hidden
            EndContext();
            BeginContext(1956, 159, true);
            WriteLiteral("</section>\n            </article>\n\n            <article class=\"esh-orders_detail-items row\">\n                <section class=\"esh-orders_detail-item col-xs-12\">");
            EndContext();
            BeginContext(2116, 26, false);
#line 48 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
                                                             Write(Model.ShippingAddress.City);

#line default
#line hidden
            EndContext();
            BeginContext(2142, 159, true);
            WriteLiteral("</section>\n            </article>\n\n            <article class=\"esh-orders_detail-items row\">\n                <section class=\"esh-orders_detail-item col-xs-12\">");
            EndContext();
            BeginContext(2302, 29, false);
#line 52 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
                                                             Write(Model.ShippingAddress.Country);

#line default
#line hidden
            EndContext();
            BeginContext(2331, 280, true);
            WriteLiteral(@"</section>
            </article>
        </section>

        <section class=""esh-orders_detail-section"">
            <article class=""esh-orders_detail-titles row"">
                <section class=""esh-orders_detail-title col-xs-12"">ORDER DETAILS</section>
            </article>

");
            EndContext();
#line 61 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
             for (int i = 0; i < Model.OrderItems.Count; i++)
            {
                var item = Model.OrderItems[i];

#line default
#line hidden
            BeginContext(2735, 239, true);
            WriteLiteral("                <article class=\"esh-orders_detail-items esh-orders_detail-items--border row\">\n                    <section class=\"esh-orders_detail-item col-md-4 hidden-md-down\">\n                        <img class=\"esh-orders_detail-image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2974, "\"", 2996, 1);
#line 66 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
WriteAttributeValue("", 2980, item.PictureUrl, 2980, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2997, 133, true);
            WriteLiteral(">\n                    </section>\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-4\">");
            EndContext();
            BeginContext(3131, 16, false);
#line 68 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
                                                                                               Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(3147, 113, true);
            WriteLiteral("</section>\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-1\">$ ");
            EndContext();
            BeginContext(3261, 29, false);
#line 69 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
                                                                                                 Write(item.UnitPrice.ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(3290, 111, true);
            WriteLiteral("</section>\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-1\">");
            EndContext();
            BeginContext(3402, 10, false);
#line 70 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
                                                                                               Write(item.Units);

#line default
#line hidden
            EndContext();
            BeginContext(3412, 113, true);
            WriteLiteral("</section>\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-2\">$ ");
            EndContext();
            BeginContext(3526, 57, false);
#line 71 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
                                                                                                 Write(Math.Round(item.Units * item.UnitPrice, 2).ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(3583, 38, true);
            WriteLiteral("</section>\n                </article>\n");
            EndContext();
#line 73 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(3635, 602, true);
            WriteLiteral(@"        </section>

        <section class=""esh-orders_detail-section esh-orders_detail-section--right"">
            <article class=""esh-orders_detail-titles esh-basket-titles--clean row"">
                <section class=""esh-orders_detail-title col-xs-9""></section>
                <section class=""esh-orders_detail-title col-xs-2"">TOTAL</section>
            </article>

            <article class=""esh-orders_detail-items row"">
                <section class=""esh-orders_detail-item col-xs-9""></section>
                <section class=""esh-orders_detail-item esh-orders_detail-item--mark col-xs-2"">$ ");
            EndContext();
            BeginContext(4238, 11, false);
#line 84 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Detail.cshtml"
                                                                                           Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(4249, 71, true);
            WriteLiteral("</section>\n            </article>\n        </section>\n    </div>\n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591