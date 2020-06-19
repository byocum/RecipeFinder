using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeFinder.Models.ViewModels
{
    public class RecipeListViewModel
    {
        public int RecipeId { get; set; }

        public string Name { get; set; }

        public string Picture { get; set; }

        [Display(Name = "Percent Match")]
        [DisplayFormat(DataFormatString = "{0:P0}")]
        [Editable(false)]
        public double PercentIngredientMatch { get; set; }

        public IEnumerable<Ingredient> Ingredients { get; set; }
    }
}
