#pragma checksum "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\AddContent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41c8a2e571248329815b4cdefd7fd14d99870cf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AddContent_Index), @"mvc.1.0.view", @"/Views/AddContent/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41c8a2e571248329815b4cdefd7fd14d99870cf2", @"/Views/AddContent/Index.cshtml")]
    public class Views_AddContent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/StyleSheets/PickIngredientsView.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\AddContent\Index.cshtml"
  
    ViewBag.Title = "Add Content";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "41c8a2e571248329815b4cdefd7fd14d99870cf23852", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<title>");
#nullable restore
#line 6 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\AddContent\Index.cshtml"
  Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n\r\n<div class=\"container-fluid feature\">\r\n    <p class=\"titleText\">Add Content</p>\r\n    <ul class=\"noBulletList\">\r\n        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 356, "\"", 407, 1);
#nullable restore
#line 12 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\AddContent\Index.cshtml"
WriteAttributeValue("", 363, Url.Action("PickIngredients", "Ingredient"), 363, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">ADD RECIPE</a>\r\n        </li>\r\n        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 468, "\"", 519, 1);
#nullable restore
#line 15 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\AddContent\Index.cshtml"
WriteAttributeValue("", 475, Url.Action("PickIngredients", "Ingredient"), 475, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">EDIT RECIPE</a>\r\n        </li>\r\n        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 581, "\"", 632, 1);
#nullable restore
#line 18 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\AddContent\Index.cshtml"
WriteAttributeValue("", 588, Url.Action("PickIngredients", "Ingredient"), 588, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">VIEW RECIPE</a>\r\n        </li>\r\n        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 694, "\"", 745, 1);
#nullable restore
#line 21 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\AddContent\Index.cshtml"
WriteAttributeValue("", 701, Url.Action("PickIngredients", "Ingredient"), 701, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">ADD INGREDIENTS</a>\r\n        </li>\r\n        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 811, "\"", 862, 1);
#nullable restore
#line 24 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\AddContent\Index.cshtml"
WriteAttributeValue("", 818, Url.Action("PickIngredients", "Ingredient"), 818, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">EDIT INGREDIENTS</a>\r\n        </li>\r\n        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 929, "\"", 993, 1);
#nullable restore
#line 27 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\AddContent\Index.cshtml"
WriteAttributeValue("", 936, Url.Action("IngredientContentList", "IngredientContent"), 936, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">VIEW INGREDIENTS</a>\r\n        </li>\r\n    </ul>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591