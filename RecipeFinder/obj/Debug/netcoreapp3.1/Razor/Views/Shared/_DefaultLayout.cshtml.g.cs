#pragma checksum "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "330849665dde878b7d1a801a13486104e377b033"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DefaultLayout), @"mvc.1.0.view", @"/Views/Shared/_DefaultLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"330849665dde878b7d1a801a13486104e377b033", @"/Views/Shared/_DefaultLayout.cshtml")]
    public class Views_Shared__DefaultLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/StyleSheets/PickIngredientsView.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/FoodFinderLogo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
  
    ViewBag.Title = "Recipe Finder";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "330849665dde878b7d1a801a13486104e377b0334949", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <title>");
#nullable restore
#line 10 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    <link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css\" integrity=\"sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l\" crossorigin=\"anonymous\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "330849665dde878b7d1a801a13486104e377b0335804", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "330849665dde878b7d1a801a13486104e377b0337774", async() => {
                WriteLiteral("\r\n    <header>\r\n        <nav class=\"navbar navbar-expand-md\">\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 607, "\"", 658, 1);
#nullable restore
#line 17 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
WriteAttributeValue("", 614, Url.Action("PickIngredients", "Ingredient"), 614, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "330849665dde878b7d1a801a13486104e377b0338558", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </a>
            <button class=""navbar-toggler navbar-light"" type=""button"" data-toggle=""collapse"" data-target=""#main-navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""main-navigation"">
                <ul class=""navbar-nav"">
                    <li class=""nav-item"">
                        <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 1168, "\"", 1219, 1);
#nullable restore
#line 26 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
WriteAttributeValue("", 1175, Url.Action("PickIngredients", "Ingredient"), 1175, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">FIND RECIPE</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 1351, "\"", 1392, 1);
#nullable restore
#line 29 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
WriteAttributeValue("", 1358, Url.Action("Index", "AddContent"), 1358, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">LOGIN</a>\r\n                    </li>\r\n\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n");
#nullable restore
#line 35 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
         if (ViewBag.NumFindRecipeBreadcrumbsDisplayed != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <nav>\r\n                <ol class=\"breadcrumb\">\r\n");
#nullable restore
#line 39 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
                     if (ViewBag.NumFindRecipeBreadcrumbsDisplayed > 0)
                    {
                        if (ViewBag.NumFindRecipeBreadcrumbsDisplayed == 1)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"breadcrumb-item active\">\r\n                                PICK INGREDIENTS\r\n                            </li>\r\n");
#nullable restore
#line 46 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"breadcrumb-item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 2155, "\"", 2206, 1);
#nullable restore
#line 50 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
WriteAttributeValue("", 2162, Url.Action("PickIngredients", "Ingredient"), 2162, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">PICK INGREDIENTS</a>\r\n                            </li>\r\n");
#nullable restore
#line 52 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
                        }

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
                     if (ViewBag.NumFindRecipeBreadcrumbsDisplayed > 1)
                    {
                        if (ViewBag.NumFindRecipeBreadcrumbsDisplayed == 2)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"breadcrumb-item active\">\r\n                                RECIPE LIST\r\n                            </li>\r\n");
#nullable restore
#line 62 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"breadcrumb-item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 2838, "\"", 2880, 1);
#nullable restore
#line 66 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
WriteAttributeValue("", 2845, Url.Action("RecipeList", "Recipe"), 2845, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">RECIPE LIST</a>\r\n                            </li>\r\n");
#nullable restore
#line 68 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
                        }

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
                     if (ViewBag.NumFindRecipeBreadcrumbsDisplayed == 3)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"breadcrumb-item active\">");
#nullable restore
#line 73 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
                                                      Write(Html.Encode(@Model.Name).ToUpper());

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 74 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </ol>\r\n            </nav>\r\n");
#nullable restore
#line 77 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </header>\r\n    <content>\r\n        <div class=\"pageMargin\">\r\n            ");
#nullable restore
#line 81 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Shared\_DefaultLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
    </content>
    <footer class=""footerCopyright"">&copy; 2020 Briony Yocum</footer>

    <!-- Scripts for bootstrap - These must be in the order of jquery, popper, bootstrap -->
    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"" integrity=""sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.min.js"" integrity=""sha384-+YQ4JLhjyBLPDQt//I+STsc9iw4uQqACwlvpslubQzn4u2UU2UFM80nGisd026JF"" crossorigin=""anonymous""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
