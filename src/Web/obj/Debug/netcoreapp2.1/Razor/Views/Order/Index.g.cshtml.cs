#pragma checksum "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d9c6499ceefd74afed04e2e4e97d0a44153c35f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Index.cshtml", typeof(AspNetCore.Views_Order_Index))]
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
#line 1 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Index.cshtml"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d9c6499ceefd74afed04e2e4e97d0a44153c35f", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"871f1400195b809d4df4ea3345169cb05634366b", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrderViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("esh-orders-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "cancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Index.cshtml"
  
    ViewData["Title"] = "My Order History";

#line default
#line hidden
            BeginContext(121, 66, true);
            WriteLiteral("\n<div class=\"esh-orders\">\n    <div class=\"container\">\n        <h1>");
            EndContext();
            BeginContext(188, 17, false);
#line 9 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(205, 430, true);
            WriteLiteral(@"</h1>
        <article class=""esh-orders-titles row"">
            <section class=""esh-orders-title col-xs-2"">Order number</section>
            <section class=""esh-orders-title col-xs-4"">Date</section>
            <section class=""esh-orders-title col-xs-2"">Total</section>
            <section class=""esh-orders-title col-xs-2"">Status</section>
            <section class=""esh-orders-title col-xs-2""></section>
        </article>
");
            EndContext();
#line 17 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Index.cshtml"
         if (Model != null && Model.Any())
        {
            

#line default
#line hidden
#line 19 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(743, 117, true);
            WriteLiteral("                <article class=\"esh-orders-items row\">\n                    <section class=\"esh-orders-item col-xs-2\">");
            EndContext();
            BeginContext(861, 46, false);
#line 22 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.OrderNumber));

#line default
#line hidden
            EndContext();
            BeginContext(907, 73, true);
            WriteLiteral("</section>\n                    <section class=\"esh-orders-item col-xs-4\">");
            EndContext();
            BeginContext(981, 44, false);
#line 23 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 75, true);
            WriteLiteral("</section>\n                    <section class=\"esh-orders-item col-xs-2\">$ ");
            EndContext();
            BeginContext(1101, 40, false);
#line 24 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 73, true);
            WriteLiteral("</section>\n                    <section class=\"esh-orders-item col-xs-2\">");
            EndContext();
            BeginContext(1215, 41, false);
#line 25 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1256, 98, true);
            WriteLiteral("</section>\n                    <section class=\"esh-orders-item col-xs-1\">\n                        ");
            EndContext();
            BeginContext(1354, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0af605087b1a48309eb4543f558017f3", async() => {
                BeginContext(1462, 6, true);
                WriteLiteral("Detail");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Index.cshtml"
                                                                                                     WriteLiteral(item.OrderNumber);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1472, 95, true);
            WriteLiteral("\n                    </section>\n                    <section class=\"esh-orders-item col-xs-1\">\n");
            EndContext();
#line 30 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Index.cshtml"
                         if (item.Status.ToLower() == "submitted")
                    {

#line default
#line hidden
            BeginContext(1656, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1684, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "956ae0c3aea544fb89050f68c8e97c34", async() => {
                BeginContext(1792, 6, true);
                WriteLiteral("Cancel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Index.cshtml"
                                                                                                         WriteLiteral(item.OrderNumber);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1802, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 33 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1829, 58, true);
            WriteLiteral("                    </section>\n                </article>\n");
            EndContext();
#line 36 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Index.cshtml"
            }

#line default
#line hidden
#line 36 "/home/andreiipadalka/eShopOnWeb/src/Web/Views/Order/Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1911, 18, true);
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
