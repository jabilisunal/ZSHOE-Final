#pragma checksum "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3588524120ece4aacd95582b33c01a6290b5f019"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Orders_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Orders/Details.cshtml")]
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
#line 3 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\_ViewImports.cshtml"
using ZSHOE.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\_ViewImports.cshtml"
using ZSHOE.Domain.AppCode.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Business.BlogPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Business.CategoryModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Business.ProductModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Business.BrandModule;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3588524120ece4aacd95582b33c01a6290b5f019", @"/Areas/Admin/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4db9c9d18359068f6063fac77767f87f2d8056e5", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("order-product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"card\">\n    <div class=\"card-header\">\n        <h5 style=\"font-size: 26px\">Order ID #");
#nullable restore
#line 9 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\Orders\Details.cshtml"
                                         Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>

    </div>
    <div class=""card-block table-border-style"">
        <div class=""table-responsive"">
            <table class=""table table-framed"">
                <thead>
                    <tr>
                        <th>Products summary</th>
                        <th>Quantity</th>
                        <th>Price</th>
                        <th>Total price</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 24 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\Orders\Details.cshtml"
                     foreach (var item in Model.OrderProducts)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <th scope=\"row\" class=\"d-flex\">\n                                <div style=\"width:70px;\" class=\"order-image-container\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3588524120ece4aacd95582b33c01a6290b5f0197546", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 967, "~/uploads/images/", 967, 17, true);
#nullable restore
#line 29 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\Orders\Details.cshtml"
AddHtmlAttributeValue("", 984, item.Product.ProductImages.FirstOrDefault().Name, 984, 49, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </div>\n                                <span class=\"product-name-center\">");
#nullable restore
#line 31 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\Orders\Details.cshtml"
                                                             Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            </th>\n                            <td>x ");
#nullable restore
#line 33 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\Orders\Details.cshtml"
                             Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 34 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\Orders\Details.cshtml"
                           Write(item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\n                            <td>");
#nullable restore
#line 35 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\Orders\Details.cshtml"
                            Write(item.Quantity * item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\n                        </tr>\n");
#nullable restore
#line 37 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\Orders\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>


<div class=""card"">
    <div class=""card-block"">
        <div class=""table-responsive"">
            <table class=""table table-xl"">
                <thead>
                    <tr>
                        <th>Customer And Order Details</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope=""row"">Customer Name</th>
                        <td>");
#nullable restore
#line 57 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\Orders\Details.cshtml"
                       Write(Model.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 57 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\Orders\Details.cshtml"
                                        Write(Model.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Phone Number</th>\n                        <td>");
#nullable restore
#line 61 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\Orders\Details.cshtml"
                       Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Shipping Address</th>\n                        <td>");
#nullable restore
#line 65 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\Orders\Details.cshtml"
                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Account email</th>\n                        <td>");
#nullable restore
#line 69 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\Orders\Details.cshtml"
                       Write(Model.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                </tbody>\n            </table>\n        </div>\n    </div>\n</div>\n\n\n<div class=\"form-group row\">\n    <div class=\"col-12 d-flex justify-content-end\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3588524120ece4aacd95582b33c01a6290b5f01913248", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591