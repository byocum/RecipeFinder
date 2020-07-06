#pragma checksum "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2ea73cc62691a2cc4477496bc108ec00027f0e6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2ea73cc62691a2cc4477496bc108ec00027f0e6", @"/Views/Ingredient/PickIngredients.cshtml")]
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
#line 4 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
  
    ViewBag.Title = "Use The Ingredients You Have";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<title>");
#nullable restore
#line 8 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
  Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</title>

<header>
    <div class=""centerWithPadding homeTitle"">
        <p class=""titleText textUnderline"">USE THE INGREDIENTS YOU HAVE!</p>

        <p class=""subtitleText centerText"">
            FIND RECIPIES WITH THE INGREDIENTS IN YOUR KITCHEN
        </p>
    </div>
</header>

");
#nullable restore
#line 20 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
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
            BeginWriteAttribute("formaction", " formaction=\"", 1094, "\"", 1137, 1);
#nullable restore
#line 30 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
WriteAttributeValue("", 1107, Url.Action("PickIngredients"), 1107, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">SELECT</button>\r\n                            </div>\r\n\r\n                            ");
#nullable restore
#line 33 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                       Write(Html.TextBoxFor(m => m.SelectedIngredient, new { autocomplete = "off", list = "dlSelectIngredient", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                            <datalist id=\"dlSelectIngredient\">\r\n");
#nullable restore
#line 37 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                                  
                                    foreach (var ingredient in @Model.Ingredients)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2ea73cc62691a2cc4477496bc108ec00027f0e66005", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
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
#line 41 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"

                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </datalist>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n                        ");
#nullable restore
#line 51 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                   Write(Html.ValidationMessageFor(m => m.SelectedIngredient, null, new { @class = "errorMessage" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <p class=\"subtitleText mt-5\">YOUR INGREDIENTS</p>\r\n\r\n");
            WriteLiteral("                        ");
#nullable restore
#line 55 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                   Write(Html.ValidationMessageFor(m => m.SelectedIngredients, null, new { @class = "errorMessage" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"errorMessage\">");
#nullable restore
#line 56 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                                              Write(TempData["SelectedIngredientError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n\r\n");
            WriteLiteral("                    ");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 62 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"








                        var count = 1;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                   Write(Html.ValidationMessageFor(p => p.SelectedIngredients));

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                                                                              ;

                        if (@Model.SelectedIngredients != null)
                        {
                            for (var index = 0; @Model.SelectedIngredients.Count() > index; index++)
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
#line 82 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-lg-4 col-md-12 col-sm-12"">
                                    <div class=""col-lg-12 col-md-12 col-sm-12 div-list grey-gradient"">
                                        <label for=""btnIngredientName"" name=""lblSelectedIngredient"">
                                            ");
#nullable restore
#line 86 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                                       Write(Model.SelectedIngredients[index].NamePlural);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            ");
#nullable restore
#line 87 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                                       Write(Html.HiddenFor(m => m.SelectedIngredients[index].IngredientNameId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            ");
#nullable restore
#line 88 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                                       Write(Html.HiddenFor(m => m.SelectedIngredients[index].NamePlural));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            ");
#nullable restore
#line 89 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
                                       Write(Html.HiddenFor(m => m.SelectedIngredients[index].RecipeIngredients));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </label>\r\n                                        <button class=\"grey-gradient\" id=\"btnIngredientName\" name=\"btnIngredientName\"");
            BeginWriteAttribute("formaction", " formaction=", 4161, "", 4214, 1);
#nullable restore
#line 91 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
WriteAttributeValue("", 4173, Url.Action("DeleteIngredientFromSearch"), 4173, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" formmethod=\"post\"");
            BeginWriteAttribute("value", " value=\"", 4232, "\"", 4284, 1);
#nullable restore
#line 91 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
WriteAttributeValue("", 4240, Model.SelectedIngredients[index].NamePlural, 4240, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">X</button>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 94 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"

                                count++;
                            }
                        }


#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            WriteLiteral("</div>\r\n");
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n                        <button id=\"btnFindRecipe\" type=\"submit\" class=\"btn btn-light btn-block mb-3 mt-3\"");
            BeginWriteAttribute("formaction", " formaction=\"", 4718, "\"", 4766, 1);
#nullable restore
#line 103 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
WriteAttributeValue("", 4731, Url.Action("RecipeList", "Recipe"), 4731, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">FIND RECIPE</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 110 "C:\Users\byocu\source\repos\GitHubRepos\RecipeFinder\RecipeFinder\Views\Ingredient\PickIngredients.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
