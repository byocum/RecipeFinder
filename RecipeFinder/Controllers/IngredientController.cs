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
            Ingredient selectedIngredient = null;

            if (await TryUpdateModelAsync<PickIngredientsViewModel>(pickIngredientsViewModel))
            {

                if (pickIngredientsViewModel.SelectedIngredient is null || pickIngredientsViewModel.SelectedIngredient.Trim() == "")
                {
                    ModelState.AddModelError("SelectedIngredient", "SELECT AN INGREDIENT");
                    HttpContext.Session.Remove("SelectedIngredients");
                }
                else
                {
                    isIngredientInARecipe = IsIngredientInARecipe(pickIngredientsViewModel);

                    isIngredientAlreadySelected = IsIngredientAlreadySelected(pickIngredientsViewModel);


                    if (isIngredientInARecipe && !isIngredientAlreadySelected)
                    {
                        selectedIngredient = await _context.Ingredients
                            .Where(i => i.NamePlural == pickIngredientsViewModel.SelectedIngredient)
                            .SingleOrDefaultAsync();

                        pickIngredientsViewModel.SelectedIngredients.Add(selectedIngredient);

                        pickIngredientsViewModel.SelectedIngredient = "";
                        ModelState.Remove("SelectedIngredient");
                    }

                    var selectedIngredientsSerialized = JsonConvert.SerializeObject(pickIngredientsViewModel.SelectedIngredients);
                    HttpContext.Session.SetString("SelectedIngredients", selectedIngredientsSerialized);
                }
            }

            return View(pickIngredientsViewModel);
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
                    ModelState.AddModelError("SelectedIngredient", pickIngredientsViewModel.SelectedIngredient + " HAS ALREADY BEEN SELECTED");
                    isIngredientAlreadySelected = true;
                }
            }

            return isIngredientAlreadySelected;
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
                    ModelState.AddModelError("SelectedIngredients", "The ingredient could not be taken off the list.");
                }
                else
                {
                    pickIngredientsViewModel.SelectedIngredients.Remove(ingredientToDelete);
                    var selectedIngredientsSerialized = JsonConvert.SerializeObject(pickIngredientsViewModel.SelectedIngredients);
                    HttpContext.Session.SetString("SelectedIngredients", selectedIngredientsSerialized);
                }
            }

            pickIngredientsViewModel.Ingredients = await _context.Ingredients
                                    .OrderBy(i => i.IngredientNameId)
                                    .ToListAsync();
            ModelState.Clear();

            return View("PickIngredients", pickIngredientsViewModel);
        }
    }
}

