#pragma checksum "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ab8c790390cc4c1069d8be78f1fabeac1ca9dbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ab8c790390cc4c1069d8be78f1fabeac1ca9dbd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"551a70ad830462fa477687857d31c4903a0ab71e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageResponse>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/homePage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/banner.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive product-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("New york"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "BikeShop HomePage";
    Layout = "_Layout";

#line default
#line hidden
            DefineSection("styles", async() => {
                BeginContext(119, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(125, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ee34fdfcd7845f0a382f3089480ee9d", async() => {
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
                BeginContext(176, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(181, 64, true);
            WriteLiteral("\r\n<div>\r\n    <div>\r\n        <div id=\"banner-img\")>\r\n            ");
            EndContext();
            BeginContext(245, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7e0b78cc801e4161afbc425f2325874f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(299, 665, true);
            WriteLiteral(@"
        </div>
        <div id=""banner-text"">
            <h1 id=""banner-big-text"">Bike Shop</h1>
            <span class=""banner-small-text"">Bikes</span><span class=""banner-small-text"">Parts</span>
            <span class=""banner-small-text"">Accessories</span><span class=""banner-small-text"">Clothing</span>
        </div>
    </div>

    <div id=""conatainers"">
        <div class=""container container-body"">
            <h1 class=""container-title"">Last added products</h1>
            <div class=""carousel-padding"">
                <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
                    <div class=""carousel-inner"">
");
            EndContext();
#line 28 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml"
                          Boolean firstLastAddedProduct = true;

#line default
#line hidden
            BeginContext(1030, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 29 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml"
                         foreach (var product in Model.LastAddedProducts)
                        {

#line default
#line hidden
            BeginContext(1132, 32, true);
            WriteLiteral("                            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1164, "\"", 1217, 2);
            WriteAttributeValue("", 1172, "item", 1172, 4, true);
#line 31 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1176, firstLastAddedProduct ? "active" : "", 1177, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1218, 111, true);
            WriteLiteral(">\r\n                                <div class=\"col-sm-3 col-sm-offset-3\">\r\n                                    ");
            EndContext();
            BeginContext(1329, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b3f105b7d16e451bb8fbdc48762d8b7b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1374, "~/images/", 1374, 9, true);
#line 33 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1383, product.Picture, 1383, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1416, 159, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-sm-4\">\r\n                                    <h4 class=\"product-name\">");
            EndContext();
            BeginContext(1576, 12, false);
#line 36 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml"
                                                        Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1588, 142, true);
            WriteLiteral("</h4>\r\n                                    <div class=\"product-price\">\r\n                                        <strong>Price: </strong><span>");
            EndContext();
            BeginContext(1731, 13, false);
#line 38 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml"
                                                                 Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1744, 166, true);
            WriteLiteral(" &euro;</span>\r\n                                    </div>\r\n                                    <div class=\"product-button\">\r\n                                        ");
            EndContext();
            BeginContext(1910, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77230a704537470da19ef05dec3b1f32", async() => {
                BeginContext(2016, 9, true);
                WriteLiteral("Show more");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml"
                                                                                                  WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2029, 122, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 45 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml"
                            firstLastAddedProduct = false;
                        }

#line default
#line hidden
            BeginContext(2238, 1084, true);
            WriteLiteral(@"                    </div>
                    <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"" style=""background:white !important"">
                        <span class=""glyphicon glyphicon-chevron-left"" style=""color:gray""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""right carousel-control"" href=""#myCarousel"" data-slide=""next"" style=""background:white !important"">
                        <span class=""glyphicon glyphicon-chevron-right"" style=""color:gray""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
            </div>
        </div>

        <div class=""container container-body"">
            <div id=""second-container-title"">
                <h1 class=""container-title"">Recommended products</h1>
            </div>
            <div class=""carousel-padding"">
                <div id=""myCarousel2"" class=""carousel slide"" data-ride=""ca");
            WriteLiteral("rousel\">\r\n                    <div class=\"carousel-inner\">\r\n");
            EndContext();
#line 67 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml"
                          Boolean firstRecommendedProduct = true;

#line default
#line hidden
            BeginContext(3390, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 68 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml"
                         foreach (var product in Model.RecommendedProducts)
                        {

#line default
#line hidden
            BeginContext(3494, 32, true);
            WriteLiteral("                            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3526, "\"", 3581, 2);
            WriteAttributeValue("", 3534, "item", 3534, 4, true);
#line 70 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3538, firstRecommendedProduct ? "active" : "", 3539, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3582, 111, true);
            WriteLiteral(">\r\n                                <div class=\"col-sm-3 col-sm-offset-3\">\r\n                                    ");
            EndContext();
            BeginContext(3693, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "df47fe93678e43f68e8f6225787641c3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3738, "~/images/", 3738, 9, true);
#line 72 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3747, product.Picture, 3747, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3780, 159, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-sm-4\">\r\n                                    <h4 class=\"product-name\">");
            EndContext();
            BeginContext(3940, 12, false);
#line 75 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml"
                                                        Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3952, 142, true);
            WriteLiteral("</h4>\r\n                                    <div class=\"product-price\">\r\n                                        <strong>Price: </strong><span>");
            EndContext();
            BeginContext(4095, 13, false);
#line 77 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml"
                                                                 Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(4108, 166, true);
            WriteLiteral(" &euro;</span>\r\n                                    </div>\r\n                                    <div class=\"product-button\">\r\n                                        ");
            EndContext();
            BeginContext(4274, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "041bcc57b8bf4200b7bcf9d9108a7cd6", async() => {
                BeginContext(4380, 9, true);
                WriteLiteral("Show more");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml"
                                                                                                  WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4393, 122, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 84 "C:\Users\Szymon\Desktop\PGS\BikeShop_dailyVersions\pgs-bikeshop-develop@7a2073e3967\BikeShop_MVC\BikeShop_MVC\Views\Home\Index.cshtml"
                            firstRecommendedProduct = false;
                        }

#line default
#line hidden
            BeginContext(4604, 738, true);
            WriteLiteral(@"                    </div>
                    <a class=""left carousel-control"" href=""#myCarousel2"" data-slide=""prev"" style=""background:white !important"">
                        <span class=""glyphicon glyphicon-chevron-left"" style=""color:gray""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""right carousel-control"" href=""#myCarousel2"" data-slide=""next"" style=""background:white !important"">
                        <span class=""glyphicon glyphicon-chevron-right"" style=""color:gray""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomePageResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
