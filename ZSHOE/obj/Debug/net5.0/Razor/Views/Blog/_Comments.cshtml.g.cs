#pragma checksum "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\_Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "686e0c01f3fc4e282c1a760592451926afc226a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog__Comments), @"mvc.1.0.view", @"/Views/Blog/_Comments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686e0c01f3fc4e282c1a760592451926afc226a8", @"/Views/Blog/_Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b75e3addd3941780439529914c0b2c6fb62ab8d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog__Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogPostComment>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\_Comments.cshtml"
 if (Model.ParentId != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n        <li>\r\n            <div class=\"comment\"");
            BeginWriteAttribute("id", " id=\"", 113, "\"", 129, 2);
            WriteAttributeValue("", 118, "c-", 118, 2, true);
#nullable restore
#line 6 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\_Comments.cshtml"
WriteAttributeValue("", 120, Model.Id, 120, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-comment-id=\"");
#nullable restore
#line 6 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\_Comments.cshtml"
                                                              Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                <div class=\"comment-body\">\r\n                    <a class=\"comment-reply\">Reply</a>\r\n                    <div class=\"comment-user\">\r\n                        <h4>");
#nullable restore
#line 10 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\_Comments.cshtml"
                        Write($"{Model.CreatedByUser?.Name} {Model.CreatedByUser?.Surname}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <span class=\"comment-date\">");
#nullable restore
#line 11 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\_Comments.cshtml"
                                              Write(Model.CreatedDate.ToString("MMMM d, yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div><!-- End .comment-user -->\r\n\r\n                    <div class=\"comment-content\">\r\n                        <p> ");
#nullable restore
#line 15 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\_Comments.cshtml"
                       Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div><!-- End .comment-content -->\r\n                </div><!-- End .comment-body -->\r\n            </div><!-- End .comment -->\r\n        </li>\r\n    </ul>\r\n");
#nullable restore
#line 21 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\_Comments.cshtml"
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>\r\n        <div class=\"comment\"");
            BeginWriteAttribute("id", " id=\"", 891, "\"", 907, 2);
            WriteAttributeValue("", 896, "c-", 896, 2, true);
#nullable restore
#line 24 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\_Comments.cshtml"
WriteAttributeValue("", 898, Model.Id, 898, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-comment-id=\"");
#nullable restore
#line 24 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\_Comments.cshtml"
                                                          Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n            <div class=\"comment-body\">\r\n                <a class=\"comment-reply\">Reply</a>\r\n                <div class=\"comment-user\">\r\n                    <h4>");
#nullable restore
#line 28 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\_Comments.cshtml"
                    Write($"{Model.CreatedByUser?.Name} {Model.CreatedByUser?.Surname}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <span class=\"comment-date\">");
#nullable restore
#line 29 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\_Comments.cshtml"
                                          Write(Model.CreatedDate.ToString("MMMM d, yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div><!-- End .comment-user -->\r\n\r\n                <div class=\"comment-content\">\r\n                    <p> ");
#nullable restore
#line 33 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\_Comments.cshtml"
                   Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div><!-- End .comment-content -->\r\n            </div><!-- End .comment-body -->\r\n        </div><!-- End .comment -->\r\n    </li>\r\n");
#nullable restore
#line 38 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\_Comments.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogPostComment> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
