#pragma checksum "C:\Users\Yasin\Desktop\Sample_MVCECommerce\ECommerce\Views\ECO\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1d8aaf43d01fb63b55b265da6eb5dd12466a96d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ECO_List), @"mvc.1.0.view", @"/Views/ECO/List.cshtml")]
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
#line 1 "C:\Users\Yasin\Desktop\Sample_MVCECommerce\ECommerce\Views\_ViewImports.cshtml"
using ECommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yasin\Desktop\Sample_MVCECommerce\ECommerce\Views\_ViewImports.cshtml"
using ECommerce.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Yasin\Desktop\Sample_MVCECommerce\ECommerce\Views\ECO\List.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1d8aaf43d01fb63b55b265da6eb5dd12466a96d", @"/Views/ECO/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89fb089828dd866504103bfaeb2b6e1f9939c572", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ECO_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""product-big-title-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""product-bit-title text-center"">
                    <h2>ALIŞVERİŞ</h2>
                </div>
            </div>
        </div>
    </div>
</div>



    <div class=""single-product-area"">
        <div class=""zigzag-bottom""></div>
        <div class=""container"">
            <div class=""row"">
");
#nullable restore
#line 22 "C:\Users\Yasin\Desktop\Sample_MVCECommerce\ECommerce\Views\ECO\List.cshtml"
                 foreach (var item in Model)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 col-sm-6\">\n                    <div class=\"single-shop-product\">\n                        <div class=\"product-upper\">\n                            <img");
            BeginWriteAttribute("src", " src=\"", 735, "\"", 760, 1);
#nullable restore
#line 27 "C:\Users\Yasin\Desktop\Sample_MVCECommerce\ECommerce\Views\ECO\List.cshtml"
WriteAttributeValue("", 741, item.product_Stock, 741, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 761, "\"", 767, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        </div>\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 831, "\"", 838, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\Users\Yasin\Desktop\Sample_MVCECommerce\ECommerce\Views\ECO\List.cshtml"
                                  Write(item.product_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\n                        <div class=\"product-carousel-price\">\n                            <ins>$");
#nullable restore
#line 31 "C:\Users\Yasin\Desktop\Sample_MVCECommerce\ECommerce\Views\ECO\List.cshtml"
                             Write(item.product_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</ins>
                        </div>

                        <div class=""product-option-shop"">
                            <a class=""add_to_cart_button"" data-quantity=""1"" data-product_sku="""" data-product_id=""70"" rel=""nofollow"" href=""/canvas/shop/?add-to-cart=70"">Sepete Ekle</a>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 39 "C:\Users\Yasin\Desktop\Sample_MVCECommerce\ECommerce\Views\ECO\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
