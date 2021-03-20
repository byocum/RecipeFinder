
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeFinder.Models.ViewModels;
using RecipeFinder.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeFinder.Controllers
{
    public class IngredientContentController : Controller
    {
        private readonly RecipeFinderContext _context;

        public IngredientContentController(RecipeFinderContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IngredientContentList()
        {
            IngredientsListViewModel IngredientsListViewModel = new IngredientsListViewModel();
            IngredientsListViewModel.Ingredients = await _context.Ingredients
                .OrderBy(i => i.IngredientNameId)
                .ToListAsync();
            return View(IngredientsListViewModel);
        }
        //public Task<ActionResult> AddEditIngredient()
        //{

        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("AddIngredient")]
        public async Task<IActionResult> AddIngredient_Post(IngredientsListViewModel ingredientsListViewModel )
        {
           


            if (await TryUpdateModelAsync(ingredientsListViewModel.Ingredient))
            {
                _context.Ingredients.Add(ingredientsListViewModel.Ingredient);
                _context.SaveChanges();

            }
            else
            {
                TempData["SelectedIngredientError"] = "ERROR.";
            }

            return RedirectToAction("IngredientContentList", "IngredientContent");
        }
    }
}
