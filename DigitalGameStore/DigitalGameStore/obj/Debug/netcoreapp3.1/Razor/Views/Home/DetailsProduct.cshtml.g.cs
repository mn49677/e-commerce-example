#pragma checksum "/Users/mn/Desktop/DigitalGameStore/DigitalGameStore/Views/Home/DetailsProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47b2e6f7bdfa82fefc8e0388460fcd96e50fe7df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DigitalGameStore.Views.Home.Views_Home_DetailsProduct), @"mvc.1.0.view", @"/Views/Home/DetailsProduct.cshtml")]
namespace DigitalGameStore.Views.Home
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
#line 3 "/Users/mn/Desktop/DigitalGameStore/DigitalGameStore/Views/Home/_ViewImports.cshtml"
using DigitalGameStore.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/mn/Desktop/DigitalGameStore/DigitalGameStore/Views/Home/_ViewImports.cshtml"
using DigitalGameStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b2e6f7bdfa82fefc8e0388460fcd96e50fe7df", @"/Views/Home/DetailsProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"585c2e7c57264e727758256952b35e639790b068", @"/Views/Home/_ViewImports.cshtml")]
    public class Views_Home_DetailsProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DigitalGameStore.ViewModels.AddProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/mn/Desktop/DigitalGameStore/DigitalGameStore/Views/Home/DetailsProduct.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    html, body {
        height: 100%;
        width: 100%;
        margin: 0;
        font-family: 'Roboto', sans-serif;
    }

    .container {
        max-width: 1200px;
        margin: 0 auto;
        padding: 15px;
        display: flex;
    }
    /* Columns */
    .left-column {
        width: 65%;
        position: relative;
    }

    .right-column {
        width: 35%;
        margin-top: 60px;
    }
    /* Left Column */
    .left-column img {
        width: 80%;
        border: 50px;
    }

        .left-column img.active {
            opacity: 1;
        }
    /* Product Description */
    .product-description {
        border-bottom: 1px solid #E1E8EE;
        margin-bottom: 20px;
    }

        .product-description span {
            font-size: 12px;
            color: #358ED7;
            letter-spacing: 1px;
            text-transform: uppercase;
            text-decoration: none;
        }

        .product-description h1 {
           ");
            WriteLiteral(@" font-weight: 300;
            font-size: 52px;
            color: #43484D;
            letter-spacing: -2px;
        }

        .product-description p {
            font-size: 16px;
            font-weight: 300;
            color: #86939E;
            line-height: 24px;
        }
    
    /* Product Price */
    .product-price {
        display: flex;
        align-items: center;
    }

        .product-price span {
            font-size: 26px;
            font-weight: 300;
            color: #43474D;
            margin-right: 20px;
        }

    .cart-btn {
        display: inline-block;
        background-color: #7DC855;
        border-radius: 6px;
        font-size: 16px;
        color: #FFFFFF;
        text-decoration: none;
        padding: 12px 30px;
        transition: all .5s;
    }

        .cart-btn:hover {
            background-color: #64af3d;
        }
</style>

<main class=""container"">

    <!-- Left Column -->
    <div class=""left-column"">
       ");
            WriteLiteral(" <img");
            BeginWriteAttribute("src", " src=\"", 2153, "\"", 2200, 1);
#nullable restore
#line 101 "/Users/mn/Desktop/DigitalGameStore/DigitalGameStore/Views/Home/DetailsProduct.cshtml"
WriteAttributeValue("", 2159, Url.Content(Model.Product.ProductImgUrl), 2159, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"img\">\r\n    </div>\r\n\r\n\r\n    <!-- Right Column -->\r\n    <div class=\"right-column\">\r\n\r\n        <!-- Product Description -->\r\n        <div class=\"product-description\">\r\n            <span>");
#nullable restore
#line 110 "/Users/mn/Desktop/DigitalGameStore/DigitalGameStore/Views/Home/DetailsProduct.cshtml"
             Write(Model.ProductClasses.Where(pc=> pc.ProductClassId == Model.Product.ProductClassId).FirstOrDefault().ProductClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <h1>");
#nullable restore
#line 111 "/Users/mn/Desktop/DigitalGameStore/DigitalGameStore/Views/Home/DetailsProduct.cshtml"
           Write(Model.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p>");
#nullable restore
#line 112 "/Users/mn/Desktop/DigitalGameStore/DigitalGameStore/Views/Home/DetailsProduct.cshtml"
          Write(Model.Product.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <!-- Product Pricing -->\r\n        <div class=\"product-price\">\r\n            <span>");
#nullable restore
#line 117 "/Users/mn/Desktop/DigitalGameStore/DigitalGameStore/Views/Home/DetailsProduct.cshtml"
             Write(Model.Product.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" HRK</span>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47b2e6f7bdfa82fefc8e0388460fcd96e50fe7df8000", async() => {
                WriteLiteral("Dodaj u košaricu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DigitalGameStore.ViewModels.AddProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591