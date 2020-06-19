using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RecipeFinder.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name="Picture Path")]
        [Required]
        [StringLength(50)]
        public string Picture { get; set; }

        [Display(Name="Directions Path")]
        [Required]
        [StringLength(50)]
        public string Directions { get; set; }

        [Display(Name="PREP")]
        [StringLength(15)]
        public string PrepTime { get; set; }
        
        [Display(Name="BAKE")]
        [StringLength(15)]
        public string BakeTime { get; set; }
        
        [Display(Name="MAKES")]
        [StringLength(15)]
        public string Servings { get; set; }

        public IEnumerable<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
