#pragma checksum "/Users/calerohdy/Desktop/Projects/MerchWebsite/Views/Shared/_ShippingDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "639dcac1f2331dfe2b1a49faed3e22fdbf1a7593"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ShippingDetail), @"mvc.1.0.view", @"/Views/Shared/_ShippingDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ShippingDetail.cshtml", typeof(AspNetCore.Views_Shared__ShippingDetail))]
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
#line 1 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Views/_ViewImports.cshtml"
using MerchWebsite;

#line default
#line hidden
#line 2 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Views/_ViewImports.cshtml"
using MerchWebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"639dcac1f2331dfe2b1a49faed3e22fdbf1a7593", @"/Views/Shared/_ShippingDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"249115d2d655fa036a68974c473149af894b6ee5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ShippingDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MerchWebsite.Models.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "item.Id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 25, true);
            WriteLiteral("\n<div class=\"container\">\n");
            EndContext();
#line 4 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Views/Shared/_ShippingDetail.cshtml"
     if(Model.Count > 0)
    {

#line default
#line hidden
            BeginContext(98, 194, true);
            WriteLiteral("    <table class=\"table table-striped\" style=\"width: 100%;\">\n        <tr>\n            <th style=\"text-align:center;width: 20%;\"></th>\n            <th style=\"text-align:center;\">\n                ");
            EndContext();
            BeginContext(292, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd86873a73bc44e2ae20a9ab18a968b1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 10 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Views/Shared/_ShippingDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(346, 79, true);
            WriteLiteral("\n            </th>\n            <th style=\"text-align:center;\">\n                ");
            EndContext();
            BeginContext(425, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c78bd41714d484c910e4c44a1cc27ed", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 13 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Views/Shared/_ShippingDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().Price);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(480, 111, true);
            WriteLiteral("                                \n            </th>\n            <th style=\"text-align:center;\">\n                ");
            EndContext();
            BeginContext(591, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5179bb870a69414fad47d204a8283dcf", async() => {
                BeginContext(644, 6, true);
                WriteLiteral("Design");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 16 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Views/Shared/_ShippingDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().DesignStyle);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(658, 111, true);
            WriteLiteral("                                \n            </th>\n            <th style=\"text-align:center;\">\n                ");
            EndContext();
            BeginContext(769, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb7a5ebac3bf4600806d2c25e8d70542", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 19 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Views/Shared/_ShippingDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().ProductTypes.Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(836, 127, true);
            WriteLiteral("                                \n            </th>\n            <th style=\"text-align:center;\">\n            </th>\n        </tr>\n");
            EndContext();
#line 24 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Views/Shared/_ShippingDetail.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1010, 81, true);
            WriteLiteral("            <tr style=\"padding: 50px;\">\n                <td>\n                    ");
            EndContext();
            BeginContext(1091, 256, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cc328ba614240debafdb6e0eccd8920", async() => {
                BeginContext(1180, 29, true);
                WriteLiteral("\n                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1209, "\"", 1226, 1);
#line 29 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Views/Shared/_ShippingDetail.cshtml"
WriteAttributeValue("", 1215, item.Image, 1215, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1227, 116, true);
                WriteLiteral(" width=\"100%\" style=\"margin:auto; display:block; border-radius:5px; border: 1px solid black;\"/>\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1347, 92, true);
            WriteLiteral("\n                </td>\n                <td style=\"text-align: center;\">\n                    ");
            EndContext();
            BeginContext(1440, 31, false);
#line 33 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Views/Shared/_ShippingDetail.cshtml"
               Write(Html.DisplayFor(c => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1471, 92, true);
            WriteLiteral("\n                </td>\n                <td style=\"text-align: center;\">\n                    ");
            EndContext();
            BeginContext(1564, 32, false);
#line 36 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Views/Shared/_ShippingDetail.cshtml"
               Write(Html.DisplayFor(c => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 92, true);
            WriteLiteral("\n                </td>\n                <td style=\"text-align: center;\">\n                    ");
            EndContext();
            BeginContext(1689, 38, false);
#line 39 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Views/Shared/_ShippingDetail.cshtml"
               Write(Html.DisplayFor(c => item.DesignStyle));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 92, true);
            WriteLiteral("\n                </td>\n                <td style=\"text-align: center;\">\n                    ");
            EndContext();
            BeginContext(1820, 44, false);
#line 42 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Views/Shared/_ShippingDetail.cshtml"
               Write(Html.DisplayFor(c => item.ProductTypes.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1864, 257, true);
            WriteLiteral(@"
                </td>
                <td style=""text-align: center;"">
                </td>                                                                                                                                                 
            </tr>
");
            EndContext();
#line 47 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Views/Shared/_ShippingDetail.cshtml"
        }

#line default
#line hidden
            BeginContext(2131, 13, true);
            WriteLiteral("    </table>\n");
            EndContext();
#line 49 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Views/Shared/_ShippingDetail.cshtml"
    }

#line default
#line hidden
            BeginContext(2150, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MerchWebsite.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591