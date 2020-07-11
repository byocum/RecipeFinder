using System.Collections.Generic;

namespace RecipeFinder.Models.ViewModels
{
    public class PickIngredientsViewModel
    {
        public string SelectedIngredient { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public List<Ingredient> SelectedIngredients { get; set; }
    }
}
