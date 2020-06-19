using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeFinder.Models.ViewModels
{
    public class PickIngredientsViewModel
    {
        public string SelectedIngredient { get; set; }

        //These are List instead of IEnumerable because IEnumerable does not have an index whereas List does.
        public List<Ingredient> Ingredients { get; set; }

        public List<Ingredient> SelectedIngredients { get; set; }
    }
}
