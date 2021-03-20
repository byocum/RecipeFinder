using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeFinder.Models.ViewModels
{
    public class IngredientsListViewModel
    {
        public Ingredient Ingredient { get;  set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
