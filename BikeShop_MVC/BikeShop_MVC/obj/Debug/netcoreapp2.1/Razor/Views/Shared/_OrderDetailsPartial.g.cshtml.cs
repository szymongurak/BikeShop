#pragma checksum "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Shared\_OrderDetailsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30a89853f042d6c58d58fdef61b620d150a240e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__OrderDetailsPartial), @"mvc.1.0.view", @"/Views/Shared/_OrderDetailsPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_OrderDetailsPartial.cshtml", typeof(AspNetCore.Views_Shared__OrderDetailsPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a89853f042d6c58d58fdef61b620d150a240e3", @"/Views/Shared/_OrderDetailsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"551a70ad830462fa477687857d31c4903a0ab71e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__OrderDetailsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderDetailsResponse>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/orderDetails.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(31, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eeb4db60602f4ee5b366da977f6162d9", async() => {
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
            BeginContext(86, 285, true);
            WriteLiteral(@"

<h4 class=""section-title"">Order positions</h4>
<table class=""table table-striped"">
    <thead>
        <tr>
            <th>Product name</th>
            <th>Quantity</th>
            <th>Price</th>
            <th>TotalPrice</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 16 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Shared\_OrderDetailsPartial.cshtml"
         foreach (var orderPosition in Model.ListOdOrderPositions)
        {

#line default
#line hidden
            BeginContext(450, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(489, 27, false);
#line 19 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Shared\_OrderDetailsPartial.cshtml"
               Write(orderPosition.NameOfProduct);

#line default
#line hidden
            EndContext();
            BeginContext(516, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(544, 22, false);
#line 20 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Shared\_OrderDetailsPartial.cshtml"
               Write(orderPosition.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(566, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(594, 19, false);
#line 21 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Shared\_OrderDetailsPartial.cshtml"
               Write(orderPosition.Price);

#line default
#line hidden
            EndContext();
            BeginContext(613, 34, true);
            WriteLiteral(" &euro;</td>\r\n                <td>");
            EndContext();
            BeginContext(648, 24, false);
#line 22 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Shared\_OrderDetailsPartial.cshtml"
               Write(orderPosition.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(672, 33, true);
            WriteLiteral(" &euro;</td>\r\n            </tr>\r\n");
            EndContext();
#line 24 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Shared\_OrderDetailsPartial.cshtml"
        }

#line default
#line hidden
            BeginContext(716, 183, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<div class=\"row\" id=\"user-data\">\r\n    <div class=\"col-sm-6\">\r\n        <h4 class=\"section-title\">User data</h4>\r\n        <h5><strong>First name: </strong><span>");
            EndContext();
            BeginContext(900, 24, false);
#line 30 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Shared\_OrderDetailsPartial.cshtml"
                                          Write(Model.UserData.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(924, 60, true);
            WriteLiteral("</span></h5>\r\n        <h5><strong>Last name: </strong><span>");
            EndContext();
            BeginContext(985, 23, false);
#line 31 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Shared\_OrderDetailsPartial.cshtml"
                                         Write(Model.UserData.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1008, 56, true);
            WriteLiteral("</span></h5>\r\n        <h5><strong>Email: </strong><span>");
            EndContext();
            BeginContext(1065, 20, false);
#line 32 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Shared\_OrderDetailsPartial.cshtml"
                                     Write(Model.UserData.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1085, 63, true);
            WriteLiteral("</span></h5>\r\n        <h5><strong>Phone number: </strong><span>");
            EndContext();
            BeginContext(1149, 26, false);
#line 33 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Shared\_OrderDetailsPartial.cshtml"
                                            Write(Model.UserData.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1175, 58, true);
            WriteLiteral("</span></h5>\r\n        <h5><strong>Address: </strong><span>");
            EndContext();
            BeginContext(1234, 22, false);
#line 34 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Shared\_OrderDetailsPartial.cshtml"
                                       Write(Model.UserData.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1256, 55, true);
            WriteLiteral("</span></h5>\r\n        <h5><strong>City: </strong><span>");
            EndContext();
            BeginContext(1312, 19, false);
#line 35 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Shared\_OrderDetailsPartial.cshtml"
                                    Write(Model.UserData.City);

#line default
#line hidden
            EndContext();
            BeginContext(1331, 58, true);
            WriteLiteral("</span></h5>\r\n        <h5><strong>Country: </strong><span>");
            EndContext();
            BeginContext(1390, 22, false);
#line 36 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Shared\_OrderDetailsPartial.cshtml"
                                       Write(Model.UserData.Country);

#line default
#line hidden
            EndContext();
            BeginContext(1412, 158, true);
            WriteLiteral("</span></h5>\r\n    </div>\r\n    <div class=\"col-sm-6\">\r\n        <h4 class=\"section-title\">Delivery data</h4>\r\n        <h5><strong>Shipment type: </strong><span>");
            EndContext();
            BeginContext(1571, 33, false);
#line 40 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Shared\_OrderDetailsPartial.cshtml"
                                             Write(Model.ShipmentData.TypeOfShipment);

#line default
#line hidden
            EndContext();
            BeginContext(1604, 65, true);
            WriteLiteral("</span></h5>\r\n        <h5><strong>Shipment price: </strong><span>");
            EndContext();
            BeginContext(1670, 33, false);
#line 41 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Shared\_OrderDetailsPartial.cshtml"
                                              Write(Model.ShipmentData.CostOfShipment);

#line default
#line hidden
            EndContext();
            BeginContext(1703, 43, true);
            WriteLiteral(" &euro;</span></h5>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderDetailsResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591