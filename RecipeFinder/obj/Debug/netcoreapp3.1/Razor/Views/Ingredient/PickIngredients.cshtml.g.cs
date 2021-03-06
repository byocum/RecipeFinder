#pragma checksum "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d64f481dfc4bd3aa42b7357cb2a13e64a4d10bdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ingredient_PickIngredients), @"mvc.1.0.view", @"/Views/Ingredient/PickIngredients.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d64f481dfc4bd3aa42b7357cb2a13e64a4d10bdf", @"/Views/Ingredient/PickIngredients.cshtml")]
    public class Views_Ingredient_PickIngredients : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeFinder.Models.ViewModels.PickIngredientsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("SelectedIngredients"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
  
    ViewBag.Title = "Use The Ingredients You Have";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<title>");
#nullable restore
#line 7 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
  Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n\r\n<div class=\"centerWithPadding homeTitle\">\r\n    <p class=\"titleText textUnderline\">USE THE INGREDIENTS YOU HAVE!</p>\r\n\r\n    <p class=\"subtitleText centerText\">\r\n        FIND RECIPIES WITH THE INGREDIENTS IN YOUR KITCHEN\r\n    </p>\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 18 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""ml-3 mr-3"">
        <div class=""content centerWithPadding"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12"">
                        <label class=""formLabel"">PICK INGREDIENT</label>
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <button id=""btnSelectIngredient"" name=""btnSelectIngredient"" class=""btn btn-outline-secondary"" type=""submit""");
            BeginWriteAttribute("formaction", " formaction=\"", 1009, "\"", 1052, 1);
#nullable restore
#line 28 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
WriteAttributeValue("", 1022, Url.Action("PickIngredients"), 1022, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">SELECT</button>\r\n                            </div>\r\n\r\n                            ");
#nullable restore
#line 31 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                       Write(Html.TextBoxFor(m => m.SelectedIngredient, new { autocomplete = "off", list = "dlSelectIngredient", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                            <datalist id=\"dlSelectIngredient\">\r\n");
#nullable restore
#line 35 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                                  
                                    foreach (var ingredient in @Model.Ingredients)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d64f481dfc4bd3aa42b7357cb2a13e64a4d10bdf5983", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                                                                      WriteLiteral(ingredient.NamePlural);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"

                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </datalist>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n                        ");
#nullable restore
#line 49 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                   Write(Html.ValidationMessageFor(m => m.SelectedIngredient, null, new { @class = "errorMessage" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        <p class=\"subtitleText mt-5\">YOUR INGREDIENTS</p>\r\n                        ");
#nullable restore
#line 52 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                   Write(Html.ValidationMessageFor(m => m.SelectedIngredients, null, new { @class = "errorMessage" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"errorMessage\">");
#nullable restore
#line 53 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                                              Write(TempData["SelectedIngredientError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n\r\n");
            WriteLiteral("                    ");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 59 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"


                        var count = 1;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                   Write(Html.ValidationMessageFor(p => p.SelectedIngredients));

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                                                                              ;

                        if (@Model.SelectedIngredients != null)
                        {
                            for (var index = @Model.SelectedIngredients.Count() - 1; index > -1; index--)
                            {
                                if (count > 3)
                                {
                                    count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            WriteLiteral("</div>\r\n                                ");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 73 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-lg-4 col-md-12 col-sm-12"">
                                    <div class=""col-lg-12 col-md-12 col-sm-12 div-list grey-gradient"">
                                        <label for=""btnIngredientName"" name=""lblSelectedIngredient"">
                                            ");
#nullable restore
#line 77 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                                       Write(Model.SelectedIngredients[index].NamePlural);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            ");
#nullable restore
#line 78 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                                       Write(Html.HiddenFor(m => m.SelectedIngredients[index].IngredientNameId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            ");
#nullable restore
#line 79 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                                       Write(Html.HiddenFor(m => m.SelectedIngredients[index].NamePlural));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            ");
#nullable restore
#line 80 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                                       Write(Html.HiddenFor(m => m.SelectedIngredients[index].RecipeIngredients));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </label>\r\n                                        <button class=\"grey-gradient\" id=\"btnIngredientName\" name=\"btnIngredientName\"");
            BeginWriteAttribute("formaction", " formaction=", 3906, "", 3959, 1);
#nullable restore
#line 82 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
WriteAttributeValue("", 3918, Url.Action("DeleteIngredientFromSearch"), 3918, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" formmethod=\"post\"");
            BeginWriteAttribute("value", " value=\"", 3977, "\"", 4029, 1);
#nullable restore
#line 82 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
WriteAttributeValue("", 3985, Model.SelectedIngredients[index].NamePlural, 3985, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">X</button>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 85 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"

                                count++;
                            }
                        }


#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            WriteLiteral("</div>\r\n");
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n                        <button id=\"btnFindRecipe\" type=\"submit\" class=\"btn btn-light btn-block mb-3 mt-3\"");
            BeginWriteAttribute("formaction", " formaction=\"", 4463, "\"", 4501, 1);
#nullable restore
#line 94 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
WriteAttributeValue("", 4476, Url.Action("RecipeList"), 4476, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" formmethod=\"get\">FIND RECIPE</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 101 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeFinder.Models.ViewModels.PickIngredientsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
