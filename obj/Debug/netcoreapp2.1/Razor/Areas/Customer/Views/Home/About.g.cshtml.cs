#pragma checksum "/Users/calerohdy/Desktop/Projects/MerchWebsite/Areas/Customer/Views/Home/About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f92877cfcbc22c2400fdbaa998408e0da70564c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_About), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Home/About.cshtml", typeof(AspNetCore.Areas_Customer_Views_Home_About))]
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
#line 1 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Areas/Customer/Views/_ViewImports.cshtml"
using MerchWebsite;

#line default
#line hidden
#line 2 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Areas/Customer/Views/_ViewImports.cshtml"
using MerchWebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f92877cfcbc22c2400fdbaa998408e0da70564c", @"/Areas/Customer/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"249115d2d655fa036a68974c473149af894b6ee5", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MerchWebsite.Models.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-right btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 70, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 9 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Areas/Customer/Views/Home/About.cshtml"
         foreach(var product in Model)
        {

#line default
#line hidden
            BeginContext(164, 284, true);
            WriteLiteral(@"            <div class=""col-4"">
                <div class=""card mb-4"">
                    <div class=""card-header"" style=""text-align:center"">
                        <h4 class=""my-0 font-weight-normal"">
                            <label style=""font-size:23px;color:steelblue;"">");
            EndContext();
            BeginContext(449, 12, false);
#line 15 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Areas/Customer/Views/Home/About.cshtml"
                                                                      Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(461, 137, true);
            WriteLiteral("</label>\r\n                        </h4>\r\n                    </div>\r\n\r\n                    <img class=\"card-img-top\" style=\"height:100%;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 598, "\"", 618, 1);
#line 19 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Areas/Customer/Views/Home/About.cshtml"
WriteAttributeValue("", 604, product.Image, 604, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(619, 292, true);
            WriteLiteral(@" alt=""Card Image"" />
                    <div class=""card-body"">
                        <div class=""d-flex justify-content-between align-items-center"">
                            <div class=""btn-group"">
                                <label style=""font-size:20px; color:steelblue""><b>$");
            EndContext();
            BeginContext(912, 13, false);
#line 23 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Areas/Customer/Views/Home/About.cshtml"
                                                                              Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(925, 78, true);
            WriteLiteral("</b></label>\r\n                            </div>\r\n                            ");
            EndContext();
            BeginContext(1003, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19fff5985a0f49068e4502c54c8b2977", async() => {
                BeginContext(1128, 12, true);
                WriteLiteral("View Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Areas/Customer/Views/Home/About.cshtml"
                                                                                                                                WriteLiteral(product.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1144, 106, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 30 "/Users/calerohdy/Desktop/Projects/MerchWebsite/Areas/Customer/Views/Home/About.cshtml"
        }

#line default
#line hidden
            BeginContext(1261, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
