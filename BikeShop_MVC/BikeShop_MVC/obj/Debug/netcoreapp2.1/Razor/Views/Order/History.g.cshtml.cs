#pragma checksum "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Order\History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "010e8f2e9ba2344d407f50bc4ea1790fe360d0f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_History), @"mvc.1.0.view", @"/Views/Order/History.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/History.cshtml", typeof(AspNetCore.Views_Order_History))]
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
#line 1 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\_ViewImports.cshtml"
using BikeShop_MVC;

#line default
#line hidden
#line 2 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\_ViewImports.cshtml"
using BikeShop_Services.Products;

#line default
#line hidden
#line 3 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\_ViewImports.cshtml"
using BikeShop_DAL.Models;

#line default
#line hidden
#line 4 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\_ViewImports.cshtml"
using BikeShop_Services.Common;

#line default
#line hidden
#line 5 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\_ViewImports.cshtml"
using BikeShop_Services.DetailsOfProduct;

#line default
#line hidden
#line 6 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\_ViewImports.cshtml"
using BikeShop_Services.HomePage;

#line default
#line hidden
#line 7 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\_ViewImports.cshtml"
using BikeShop_MVC.Components;

#line default
#line hidden
#line 8 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\_ViewImports.cshtml"
using BikeShop_Services.Cart;

#line default
#line hidden
#line 9 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\_ViewImports.cshtml"
using BikeShop_Services.Infrastructure;

#line default
#line hidden
#line 10 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\_ViewImports.cshtml"
using BikeShop_Services.Orders;

#line default
#line hidden
#line 11 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\_ViewImports.cshtml"
using BikeShop_Services.Orders.HistoryOfOrders;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"010e8f2e9ba2344d407f50bc4ea1790fe360d0f2", @"/Views/Order/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"551a70ad830462fa477687857d31c4903a0ab71e", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistoryOfOrdersResponse>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/historyOfOrders.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/historyOfOrders.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Order\History.cshtml"
  
    ViewData["Title"] = "BikeShop HistoryOfOrder";
    Layout = "_Layout";

#line default
#line hidden
            DefineSection("styles", async() => {
                BeginContext(132, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(138, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d045a2b0aed54c6f9aa5b1b9c29023ad", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(196, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(201, 486, true);
            WriteLiteral(@"<div class=""container-fluid"" id=""list-of-orders"">
    <div class=""col-sm-3"">
    </div>
    <div class=""col-sm-6"">
        <h2 id=""title"">History of orders</h2>
        <table class=""table table-sm table-hover"">
            <thead>
                <tr>
                    <th>Order Id</th>
                    <th>Order Data</th>
                    <th>Total Cost</th>
                    <th>Details</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 24 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Order\History.cshtml"
                 foreach (var order in Model.ListOfOrders)
                {

#line default
#line hidden
            BeginContext(766, 61, true);
            WriteLiteral("                    <tr data-toggle=\"collapse\" data-target=\"#");
            EndContext();
            BeginContext(828, 13, false);
#line 26 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Order\History.cshtml"
                                                        Write(order.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(841, 57, true);
            WriteLiteral("\" class=\"accordion-toggle\">\r\n                        <td>");
            EndContext();
            BeginContext(899, 13, false);
#line 27 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Order\History.cshtml"
                       Write(order.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(912, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(948, 15, false);
#line 28 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Order\History.cshtml"
                       Write(order.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(963, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(999, 15, false);
#line 29 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Order\History.cshtml"
                       Write(order.TotalCost);

#line default
#line hidden
            EndContext();
            BeginContext(1014, 110, true);
            WriteLiteral(" &euro;</td>\r\n                        <td><button class=\"btn btn-primary btn-sm detailsButton\" data-order-id=\"");
            EndContext();
            BeginContext(1125, 13, false);
#line 30 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Order\History.cshtml"
                                                                                           Write(order.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(1138, 254, true);
            WriteLiteral("\"><span class=\"glyphicon glyphicon-plus detailsIcon\"></span></button></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td colspan=\"12\" class=\"hiddenRow\">\r\n                            <div class=\"accordian-body collapse\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1392, "\"", 1411, 1);
#line 34 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Order\History.cshtml"
WriteAttributeValue("", 1397, order.OrderId, 1397, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1412, 78, true);
            WriteLiteral(">\r\n                                <div class=\"detailsPartial\" data-order-id=\"");
            EndContext();
            BeginContext(1491, 13, false);
#line 35 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Order\History.cshtml"
                                                                      Write(order.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(1504, 138, true);
            WriteLiteral("\">\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 40 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Order\History.cshtml"
                }

#line default
#line hidden
            BeginContext(1661, 48, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n        ");
            EndContext();
            BeginContext(1710, 138, false);
#line 43 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Order\History.cshtml"
   Write(await Component.InvokeAsync("Paging", new { url = Model.GetCurrentUrl(Url), pageSize = Model.PageCount, currentPage = Model.CurrentPage }));

#line default
#line hidden
            EndContext();
            BeginContext(1848, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("customScripts", async() => {
                BeginContext(1893, 100, true);
                WriteLiteral("\r\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js\"></script>\r\n    ");
                EndContext();
                BeginContext(1993, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "803187ae7d2c49c183272963ed627323", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2040, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistoryOfOrdersResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
