using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            Models.ViewModels.IngredientsListViewModel IngredientsListViewModel = new Models.ViewModels.IngredientsListViewModel();
            IngredientsListViewModel.Ingredients = await _context.Ingredients
                .OrderBy(i => i.IngredientNameId)
                .ToListAsync();
            return View(IngredientsListViewModel);
        }
    }
}
