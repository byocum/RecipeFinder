using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using RecipeFinder.Data;
using RecipeFinder.Models;
using RecipeFinder.Models.ViewModels;
using Newtonsoft.Json;

namespace RecipeFinder.Controllers
{
    public class RecipeController : Controller
    {
        private readonly RecipeFinderContext _context;

        public RecipeController(RecipeFinderContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ViewResult RecipeList()
        {
            List<RecipeListViewModel> recipeListViewModel = new List<RecipeListViewModel>();
            var selectedIngredientsSession = HttpContext.Session.GetString("SelectedIngredients");


            if (!string.IsNullOrEmpty(selectedIngredientsSession))
            {
                List<Ingredient> selectedIngredients = JsonConvert.DeserializeObject<List<Ingredient>>(selectedIngredientsSession);

                recipeListViewModel =  CreateRecipeList(selectedIngredients);

                return View(recipeListViewModel);
            }
            else
            {
                TempData["NoRecipiesError"] = "NO RECIPIES WERE FOUND.";
            }

            return View();
        }

        private List<RecipeListViewModel> CreateRecipeList(List<Ingredient> selectedIngredients)
        {
            List<RecipeListViewModel> recipeListViewModel = new List<RecipeListViewModel>();

            List<Recipe> recipeList = _context.RecipeIngredients
                               .Where(ri => selectedIngredients.Contains(ri.Ingredient))
                               .Include(ri => ri.Recipe)
                               .ThenInclude(r => r.RecipeIngredients)
                               .ThenInclude(i => i.Ingredient)
                               .Select(ri => ri.Recipe)
                               .Distinct()
                               .ToList();

            if (recipeList.Count < 1)
            {
                TempData["NoRecipiesError"] = "NO RECIPIES WERE FOUND THAT HAD THE INGREDIENTS YOU SELECTED.";
            }
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
                    foreach (Ingredient selectedIngredient in selectedIngredients)
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

            return recipeListViewModel.OrderByDescending(r => r.PercentIngredientMatch).ToList();
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

            string[] recipeDirections = System.IO.File.ReadAllLines("wwwroot/RecipeDirections/" + recipeModel.Directions);
            ViewBag.RecipeDirections = recipeDirections;

            return View(recipeModel);
        }
    }
}