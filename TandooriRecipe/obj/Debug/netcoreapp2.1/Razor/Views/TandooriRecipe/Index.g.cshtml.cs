#pragma checksum "C:\Users\300985889\RiderProjects\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "845f0791adc193aaf7bf317755a81fd8d04827af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TandooriRecipe_Index), @"mvc.1.0.view", @"/Views/TandooriRecipe/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TandooriRecipe/Index.cshtml", typeof(AspNetCore.Views_TandooriRecipe_Index))]
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
#line 1 "C:\Users\300985889\RiderProjects\WebAssignmentWorking\TandooriRecipe\Views\_ViewImports.cshtml"
using TandooriRecipe;

#line default
#line hidden
#line 2 "C:\Users\300985889\RiderProjects\WebAssignmentWorking\TandooriRecipe\Views\_ViewImports.cshtml"
using TandooriRecipe.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"845f0791adc193aaf7bf317755a81fd8d04827af", @"/Views/TandooriRecipe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4668e9e90bec853b02f0d7cd613000bc7bf7cc4", @"/Views/_ViewImports.cshtml")]
    public class Views_TandooriRecipe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TandooriRecipe.Models.RecipeModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DisplayRecipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\300985889\RiderProjects\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\Index.cshtml"
  
	ViewData["Title"] = "Tandoori Recipe Home";
	Layout="_Layout";

#line default
#line hidden
            BeginContext(130, 16, true);
            WriteLiteral("\r\n            \r\n");
            EndContext();
#line 9 "C:\Users\300985889\RiderProjects\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\Index.cshtml"
 foreach (TandooriRecipe.Models.RecipeModel item in @Model)
{

#line default
#line hidden
            BeginContext(210, 111, true);
            WriteLiteral("    <div class=\"jumbotron jumbotron-fluid\">\r\n        <div class=\"container\">\r\n            <p class=\"display-2\">");
            EndContext();
            BeginContext(322, 9, false);
#line 13 "C:\Users\300985889\RiderProjects\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\Index.cshtml"
                            Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(331, 39, true);
            WriteLiteral("</p>\r\n            <p class=\"display-3\">");
            EndContext();
            BeginContext(371, 11, false);
#line 14 "C:\Users\300985889\RiderProjects\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\Index.cshtml"
                            Write(item.Author);

#line default
#line hidden
            EndContext();
            BeginContext(382, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(384, 17, false);
#line 14 "C:\Users\300985889\RiderProjects\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\Index.cshtml"
                                         Write(item.TimeRequired);

#line default
#line hidden
            EndContext();
            BeginContext(401, 34, true);
            WriteLiteral("</p>\r\n            <p class=\"lead\">");
            EndContext();
            BeginContext(436, 16, false);
#line 15 "C:\Users\300985889\RiderProjects\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\Index.cshtml"
                       Write(item.Ingredients);

#line default
#line hidden
            EndContext();
            BeginContext(452, 34, true);
            WriteLiteral("</p>\r\n            <p class=\"lead\">");
            EndContext();
            BeginContext(487, 15, false);
#line 16 "C:\Users\300985889\RiderProjects\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\Index.cshtml"
                       Write(item.Directions);

#line default
#line hidden
            EndContext();
            BeginContext(502, 18, true);
            WriteLiteral("</p>\r\n            ");
            EndContext();
            BeginContext(520, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6298dfd8a2140f7826f2dd7ae49e8ce", async() => {
                BeginContext(580, 38, true);
                WriteLiteral("<p class=\"lead\"> See Full Recipe </p> ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\300985889\RiderProjects\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\Index.cshtml"
                                            WriteLiteral(item.RecipeId);

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
            BeginContext(622, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 20 "C:\Users\300985889\RiderProjects\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TandooriRecipe.Models.RecipeModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
