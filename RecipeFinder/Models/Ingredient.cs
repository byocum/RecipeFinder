using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeFinder.Models
{
    public class Ingredient
    {
        [Display(Name = "Name")]
        [StringLength(25)]
        [Required]
        [Key]
        public string IngredientNameId { get; set; }

        [Display(Name = "Plural Name")]
        [StringLength(25)]
        [Required]
        public string NamePlural { get; set; }

        public IEnumerable<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
