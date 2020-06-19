using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeFinder.Data;
using RecipeFinder.Models;
using RecipeFinder.Models.ViewModels;

namespace RecipeFinder.Controllers
{
    public class RecipeController : Controller
    {
        private readonly RecipeFinderContext _context;

        public RecipeController(RecipeFinderContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RecipeList()
        {
            List<Ingredient> searchIngredients = new List<Ingredient>();
            List<RecipeListViewModel> recipeListViewModel = new List<RecipeListViewModel>();
            PickIngredientsViewModel pickIngredientsViewModel = new PickIngredientsViewModel();
            if (await TryUpdateModelAsync<PickIngredientsViewModel>(pickIngredientsViewModel))
            {
                if (pickIngredientsViewModel.SelectedIngredients is null)
                {
                    TempData["SelectedIngredientError"] = "No ingredients specified for search.";
                }
                else
                {

                    List<Recipe> recipeList = _context.RecipeIngredients
                                .Where(ri => pickIngredientsViewModel.SelectedIngredients.Contains(ri.Ingredient))
                                .Include(ri => ri.Recipe)
                                .ThenInclude(r => r.RecipeIngredients)
                                .ThenInclude(i => i.Ingredient)
                                .Select(ri => ri.Recipe)
                                .Distinct()
                                .ToList();

                    foreach (var recipe in recipeList)
                    {
                        RecipeListViewModel recipeToAdd = new RecipeListViewModel();

                        recipeToAdd.RecipeId = recipe.RecipeId;
                        recipeToAdd.Name = recipe.Name;
                        recipeToAdd.Picture = recipe.Picture;
                        recipeToAdd.Ingredients = recipe.RecipeIngredients.Select(i => i.Ingredient);

                        var ingredientsInRecipeCount = recipeToAdd.Ingredients.Count();
                        var selectedIngredientsInRecipeCount = 0;

                        foreach (Ingredient ingredient in recipeToAdd.Ingredients)
                        {
                            foreach (Ingredient selectedIngredient in pickIngredientsViewModel.SelectedIngredients)
                            {
                                if (ingredient.IngredientNameId == selectedIngredient.IngredientNameId)
                                {
                                    selectedIngredientsInRecipeCount++;
                                }
                            }
                        }

                        recipeToAdd.PercentIngredientMatch = selectedIngredientsInRecipeCount / (double)ingredientsInRecipeCount;

                        recipeListViewModel.Add(recipeToAdd);
                    }

                    var recipeListViewOrdered = recipeListViewModel.OrderByDescending(r => r.PercentIngredientMatch);
                    return View(recipeListViewOrdered);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult RecipeDetail(string recipeId)
        {
            RecipeViewModel recipeViewModel = new RecipeViewModel();
            Recipe recipeModel = new Recipe();


            recipeModel = _context.Recipes
              .Where(r => r.RecipeId == Convert.ToInt32(recipeId))
              .Include(r => r.RecipeIngredients)
              .ThenInclude(ri => ri.Ingredient)
              .SingleOrDefault();

            string[] recipeDirections = System.IO.File.ReadAllLines("wwwroot/RecipeDirections/SwissSteakDirections.txt");
                ViewBag.RecipeDirections = recipeDirections;

            return View(recipeModel);
        }
    }
}