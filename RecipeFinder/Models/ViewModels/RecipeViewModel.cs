using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeFinder.Models.ViewModels
{
    public class RecipeViewModel
    {
        public int RecipeId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Picture Path")]
        [Required]
        [StringLength(50)]
        public string Picture { get; set; }

        [Display(Name = "Directions Path")]
        [Required]
        [StringLength(50)]
        public string Directions { get; set; }

        [Display(Name = "Prep Time")]
        [StringLength(15)]
        public string PrepTime { get; set; }

        [Display(Name = "Bake Time")]
        [StringLength(15)]
        public string BakeTime { get; set; }

        [StringLength(15)]
        public string Servings { get; set; }

        public IEnumerable<Ingredient> Ingredients { get; set; }
    }
}
