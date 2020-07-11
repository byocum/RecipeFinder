using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeFinder.Models
{
    public class RecipeIngredient
    {
        [ForeignKey("Recipe")]
        public int RecipeId { get; set; }

       [ForeignKey("Ingredient")]
        public string IngredientNameId { get; set; }

        [Required]
        [StringLength(50)]
        public string Amount { get; set; }

        [Required]
        [Display(Name = "Ingredient Name Plural")]
        public bool IsIngredientNamePlural { get; set; }
        public Recipe Recipe { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
