#pragma checksum "D:\USERDATA\Desktop\Core\CoreDome\Views\Components\WriterLastBlog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b0ddf6f505bdfbdf1e295162e0961266577ffb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_WriterLastBlog_Default), @"mvc.1.0.view", @"/Views/Components/WriterLastBlog/Default.cshtml")]
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
#line 1 "D:\USERDATA\Desktop\Core\CoreDome\Views\_ViewImports.cshtml"
using CoreDome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\USERDATA\Desktop\Core\CoreDome\Views\_ViewImports.cshtml"
using CoreDome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\USERDATA\Desktop\Core\CoreDome\Views\Components\WriterLastBlog\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b0ddf6f505bdfbdf1e295162e0961266577ffb6", @"/Views/Components/WriterLastBlog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e66272167ea9a5b26c9aa3a2b9ad3eb6a7671f84", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_WriterLastBlog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n                        <h4>Yazarın Diğer Yazılar</h4>\r\n\r\n");
#nullable restore
#line 7 "D:\USERDATA\Desktop\Core\CoreDome\Views\Components\WriterLastBlog\Default.cshtml"
                         foreach(var item in Model.Take(3))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <div class=\"blog-grids row mb-3\">\r\n                            <div class=\"col-md-5 blog-grid-left\">\r\n                                <a href=\"single.html\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 407, "\"", 428, 1);
#nullable restore
#line 12 "D:\USERDATA\Desktop\Core\CoreDome\Views\Components\WriterLastBlog\Default.cshtml"
WriteAttributeValue("", 413, item.BlogImage, 413, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 447, "\"", 453, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </a>\r\n                            </div>\r\n                            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                                <h5>\r\n                                    <a href=\"single.html\">");
#nullable restore
#line 18 "D:\USERDATA\Desktop\Core\CoreDome\Views\Components\WriterLastBlog\Default.cshtml"
                                                     Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                                </h5>\r\n                                <div class=\"sub-meta\">\r\n                                    <span>\r\n                                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 22 "D:\USERDATA\Desktop\Core\CoreDome\Views\Components\WriterLastBlog\Default.cshtml"
                                                                 Write(((DateTime)@item.BlogCreateDate).ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 27 "D:\USERDATA\Desktop\Core\CoreDome\Views\Components\WriterLastBlog\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n\r\n                    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
