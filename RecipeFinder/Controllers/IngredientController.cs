using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RecipeFinder.Data;
using RecipeFinder.Models;
using RecipeFinder.Models.ViewModels;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace RecipeFinder.Controllers
{
    public class IngredientController : Controller
    {
        private readonly RecipeFinderContext _context;

        public IngredientController(RecipeFinderContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> PickIngredients()
        {
            PickIngredientsViewModel pickIngredientsViewModel = new PickIngredientsViewModel();

            var selectedIngredientsSession = HttpContext.Session.GetString("SelectedIngredients");

            pickIngredientsViewModel.Ingredients = await _context.Ingredients
                .OrderBy(i => i.IngredientNameId)
                .ToListAsync();

            if (!string.IsNullOrEmpty(selectedIngredientsSession))
            {
                pickIngredientsViewModel.SelectedIngredients = JsonConvert.DeserializeObject<List<Ingredient>>(selectedIngredientsSession);
            }

            return View(pickIngredientsViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("PickIngredients")]
        public async Task<IActionResult> PickIngredients_Post()
        {
            PickIngredientsViewModel pickIngredientsViewModel = new PickIngredientsViewModel();
            pickIngredientsViewModel.SelectedIngredients = new List<Ingredient>();

            pickIngredientsViewModel.Ingredients = await _context.Ingredients
                .OrderBy(i => i.IngredientNameId)
                .ToListAsync();

            bool isIngredientInARecipe = false;
            bool isIngredientAlreadySelected = false;

            if (await TryUpdateModelAsync<PickIngredientsViewModel>(pickIngredientsViewModel))
            {

                if (pickIngredientsViewModel.SelectedIngredient is null || pickIngredientsViewModel.SelectedIngredient.Trim() == "")
                {
                    ModelState.AddModelError("SelectedIngredient", "SELECT AN INGREDIENT");
                    HttpContext.Session.Remove("SelectedIngredients");
                    return View(pickIngredientsViewModel);
                }
                else
                {
                    isIngredientInARecipe = IsIngredientInARecipe(pickIngredientsViewModel);

                    isIngredientAlreadySelected = IsIngredientAlreadySelected(pickIngredientsViewModel);


                    if (isIngredientInARecipe && !isIngredientAlreadySelected)
                    {
                        AddSelectedIngredientToSession(pickIngredientsViewModel.SelectedIngredient, pickIngredientsViewModel.SelectedIngredients);
                    }
                    else
                    {
                        return View(pickIngredientsViewModel);
                    }

                }
            }

            return RedirectToAction("PickIngredients");
        }

        private bool IsIngredientInARecipe(PickIngredientsViewModel pickIngredientsViewModel)
        {
            bool isIngredientInARecipe = false;

            foreach (var recipeIngredient in pickIngredientsViewModel.Ingredients)
            {
                if (recipeIngredient.NamePlural == pickIngredientsViewModel.SelectedIngredient)
                {
                    isIngredientInARecipe = true;
                }
            }

            if (!isIngredientInARecipe)
            {
                ModelState.AddModelError("SelectedIngredient", pickIngredientsViewModel.SelectedIngredient + " IS NOT A POSSIBLE INGREDIENT TO SELECT");
            }

            return isIngredientInARecipe;
        }

        private bool IsIngredientAlreadySelected(PickIngredientsViewModel pickIngredientsViewModel)
        {
            bool isIngredientAlreadySelected = false;

            foreach (var ingredient in pickIngredientsViewModel.SelectedIngredients)
            {
                if (ingredient.NamePlural == pickIngredientsViewModel.SelectedIngredient)
                {
                    ModelState.AddModelError("SelectedIngredient", pickIngredientsViewModel.SelectedIngredient.ToUpper() + " HAS ALREADY BEEN SELECTED");
                    isIngredientAlreadySelected = true;
                }
            }

            return isIngredientAlreadySelected;
        }

        private void AddSelectedIngredientToSession(string ingredient, List<Ingredient> selectedIngredients)
        {
            Ingredient selectedIngredient = null;

            selectedIngredient = _context.Ingredients
                .Where(i => i.NamePlural == ingredient)
                .SingleOrDefault();

            selectedIngredients.Add(selectedIngredient);

            var selectedIngredientsSerialized = JsonConvert.SerializeObject(selectedIngredients);
            HttpContext.Session.SetString("SelectedIngredients", selectedIngredientsSerialized);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteIngredientFromSearch(string btnIngredientName)
        {
            PickIngredientsViewModel pickIngredientsViewModel = new PickIngredientsViewModel();
            Ingredient ingredientToDelete = null;

            if (await TryUpdateModelAsync<PickIngredientsViewModel>(pickIngredientsViewModel))
            {
                foreach (var ingredient in pickIngredientsViewModel.SelectedIngredients)
                {
                    if (ingredient.NamePlural == btnIngredientName)
                    {
                        ingredientToDelete = ingredient;
                    }
                }

                if (ingredientToDelete == null)
                {
                    ModelState.AddModelError("SelectedIngredients", "THE INGREDIENT COULD NOT BE TAKEN OFF THE LIST.");
                }
                else
                {
                    pickIngredientsViewModel.SelectedIngredients.Remove(ingredientToDelete);
                    var selectedIngredientsSerialized = JsonConvert.SerializeObject(pickIngredientsViewModel.SelectedIngredients);
                    HttpContext.Session.SetString("SelectedIngredients", selectedIngredientsSerialized);
                }
            }

            return RedirectToAction("PickIngredients");
        }

        [HttpGet]
        public async Task<IActionResult> RecipeList()
        {
            List<RecipeListViewModel> recipeListViewModel = new List<RecipeListViewModel>();
            PickIngredientsViewModel pickIngredientsViewModel = new PickIngredientsViewModel();

            if (await TryUpdateModelAsync<PickIngredientsViewModel>(pickIngredientsViewModel))
            {
                if (pickIngredientsViewModel.SelectedIngredients is null)
                {
                    TempData["SelectedIngredientError"] = "NO INGREDENTS WERE SPECIFIED.";
                }
                else
                {
                    return RedirectToAction("RecipeList", "Recipe");
                }
            }
            return RedirectToAction("PickIngredients");
        }
    }
}

