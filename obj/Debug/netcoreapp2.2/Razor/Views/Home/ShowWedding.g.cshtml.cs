#pragma checksum "/Users/aldomagana/Documents/CodingDojo/CSharp/wedding_planner/Views/Home/ShowWedding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44923497cd7f65bca3f1e069277159278021121d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowWedding), @"mvc.1.0.view", @"/Views/Home/ShowWedding.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowWedding.cshtml", typeof(AspNetCore.Views_Home_ShowWedding))]
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
#line 1 "/Users/aldomagana/Documents/CodingDojo/CSharp/wedding_planner/Views/_ViewImports.cshtml"
using wedding_planner;

#line default
#line hidden
#line 2 "/Users/aldomagana/Documents/CodingDojo/CSharp/wedding_planner/Views/_ViewImports.cshtml"
using wedding_planner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44923497cd7f65bca3f1e069277159278021121d", @"/Views/Home/ShowWedding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0aadd694686a14c367f0150bd67bec2e71f0b6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowWedding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "success", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(15, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44923497cd7f65bca3f1e069277159278021121d3991", async() => {
                BeginContext(60, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(70, 3, true);
            WriteLiteral(" |\n");
            EndContext();
            BeginContext(73, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44923497cd7f65bca3f1e069277159278021121d5539", async() => {
                BeginContext(119, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(127, 6, true);
            WriteLiteral("\n\n<h1>");
            EndContext();
            BeginContext(134, 11, false);
#line 5 "/Users/aldomagana/Documents/CodingDojo/CSharp/wedding_planner/Views/Home/ShowWedding.cshtml"
Write(Model.bride);

#line default
#line hidden
            EndContext();
            BeginContext(145, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(151, 11, false);
#line 5 "/Users/aldomagana/Documents/CodingDojo/CSharp/wedding_planner/Views/Home/ShowWedding.cshtml"
                Write(Model.groom);

#line default
#line hidden
            EndContext();
            BeginContext(162, 26, true);
            WriteLiteral("\'s Wedding</h1>\n<h4>Date: ");
            EndContext();
            BeginContext(189, 10, false);
#line 6 "/Users/aldomagana/Documents/CodingDojo/CSharp/wedding_planner/Views/Home/ShowWedding.cshtml"
     Write(Model.date);

#line default
#line hidden
            EndContext();
            BeginContext(199, 80, true);
            WriteLiteral("</h4>\n<div class=\"form-group\">\n                Guests:\n                    <ul>\n");
            EndContext();
#line 10 "/Users/aldomagana/Documents/CodingDojo/CSharp/wedding_planner/Views/Home/ShowWedding.cshtml"
                         foreach (RSVP rsvp in @Model.RSVP){

#line default
#line hidden
            BeginContext(340, 32, true);
            WriteLiteral("                            <li>");
            EndContext();
            BeginContext(373, 15, false);
#line 11 "/Users/aldomagana/Documents/CodingDojo/CSharp/wedding_planner/Views/Home/ShowWedding.cshtml"
                           Write(rsvp.User.fname);

#line default
#line hidden
            EndContext();
            BeginContext(388, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(390, 15, false);
#line 11 "/Users/aldomagana/Documents/CodingDojo/CSharp/wedding_planner/Views/Home/ShowWedding.cshtml"
                                            Write(rsvp.User.lname);

#line default
#line hidden
            EndContext();
            BeginContext(405, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 12 "/Users/aldomagana/Documents/CodingDojo/CSharp/wedding_planner/Views/Home/ShowWedding.cshtml"
                        }

#line default
#line hidden
            BeginContext(437, 33, true);
            WriteLiteral("                    </ul>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591
