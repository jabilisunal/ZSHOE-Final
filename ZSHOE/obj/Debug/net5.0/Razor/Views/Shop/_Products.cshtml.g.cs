#pragma checksum "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a10f00f867b7a704e1723b511d2ef2efc684edc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop__Products), @"mvc.1.0.view", @"/Views/Shop/_Products.cshtml")]
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
#line 4 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.AppCode.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.ViewModels.OrderViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a10f00f867b7a704e1723b511d2ef2efc684edc7", @"/Views/Shop/_Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0c45f6ef369160357c8390ee92cfca89c78a328", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop__Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedViewModel<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("  width: 100%; height: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product desc"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::ZSHOE.WebUI.AppCode.TagHelpers.RateStarTagHelper __ZSHOE_WebUI_AppCode_TagHelpers_RateStarTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n");
#nullable restore
#line 5 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
 foreach (var item in Model.Items)
{
    int intValue = Convert.ToInt32(item.Rate);
    var imagePath = item.ProductImages.FirstOrDefault()?.Name;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-6 col-md-4 col-lg-4\">\n        <div class=\"product product-7 text-center\">\n            <figure class=\"product-media\">\n               \n");
#nullable restore
#line 14 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
                 if (item.CreatedDate > DateTime.Now.AddDays(-6))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"product-label label-new\">New</span>\n");
#nullable restore
#line 17 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
                 if(intValue>1)
                {
                   

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"product-label label-top\">Top</span>\n");
#nullable restore
#line 22 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("               \n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a10f00f867b7a704e1723b511d2ef2efc684edc78529", async() => {
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a10f00f867b7a704e1723b511d2ef2efc684edc78802", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 801, "~/uploads/images/", 801, 17, true);
#nullable restore
#line 25 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
AddHtmlAttributeValue("", 818, imagePath, 818, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                <div class=\"product-action-vertical\">\n                    <a");
            BeginWriteAttribute("href", " href=\"", 971, "\"", 1013, 3);
            WriteAttributeValue("", 978, "javascript:addToFavorites(", 978, 26, true);
#nullable restore
#line 29 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
WriteAttributeValue("", 1004, item.Id, 1004, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1012, ")", 1012, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn-product-icon btn-wishlist btn-expandable""><span>add to wishlist</span></a>
                </div><!-- End .product-action-vertical -->

                <div class=""product-action"">
                    <a style=""cursor:pointer"" data-product-id=""");
#nullable restore
#line 33 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
                                                          Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" onclick=""addToBasket(event)"" class=""btn-product btn-cart""><span>add to cart</span></a>
                </div><!-- End .product-action -->
            </figure><!-- End .product-media -->

            <div class=""product-body"">
                <div class=""product-cat"">
                    <a href=""#"">");
#nullable restore
#line 39 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
                           Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </div><!-- End .product-cat -->\n                <h3 class=\"product-title\"><a href=\"product.html\">");
#nullable restore
#line 41 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3><!-- End .product-title -->\n                <div class=\"product-price\">\n                    $");
#nullable restore
#line 43 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div><!-- End .product-price -->\n                <div class=\"ratings-container\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("rate", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a10f00f867b7a704e1723b511d2ef2efc684edc715146", async() => {
            }
            );
            __ZSHOE_WebUI_AppCode_TagHelpers_RateStarTagHelper = CreateTagHelper<global::ZSHOE.WebUI.AppCode.TagHelpers.RateStarTagHelper>();
            __tagHelperExecutionContext.Add(__ZSHOE_WebUI_AppCode_TagHelpers_RateStarTagHelper);
#nullable restore
#line 46 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
__ZSHOE_WebUI_AppCode_TagHelpers_RateStarTagHelper.RateValue = item.Rate;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("rate-value", __ZSHOE_WebUI_AppCode_TagHelpers_RateStarTagHelper.RateValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 46 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
__ZSHOE_WebUI_AppCode_TagHelpers_RateStarTagHelper.ProductId = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("rate-product-id", __ZSHOE_WebUI_AppCode_TagHelpers_RateStarTagHelper.ProductId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div><!-- End .rating-container -->\n\n                <div class=\"product-nav product-nav-thumbs\">\n");
#nullable restore
#line 60 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
                     foreach (var itemImage in item.ProductImages.Where(pi => pi.IsMain == false))
                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a10f00f867b7a704e1723b511d2ef2efc684edc717412", async() => {
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a10f00f867b7a704e1723b511d2ef2efc684edc717694", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2854, "~/uploads/images/", 2854, 17, true);
#nullable restore
#line 65 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
AddHtmlAttributeValue("", 2871, itemImage.Name, 2871, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 67 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                </div><!-- End .product-nav -->\n            </div><!-- End .product-body -->\n        </div><!-- End .product -->\n    </div>\n");
            WriteLiteral("    <!-- End .col-sm-6 col-lg-4 -->\n");
#nullable restore
#line 78 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\_Products.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedViewModel<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
