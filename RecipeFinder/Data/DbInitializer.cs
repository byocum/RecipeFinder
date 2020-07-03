using System.Linq;
using RecipeFinder.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace RecipeFinder.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RecipeFinderContext context, IWebHostEnvironment env)
        {
            //If the database does not exist this will create the database
            context.Database.EnsureCreated();

            if (env.IsDevelopment() && !context.Ingredients.Any())
            {
                var ingredients = new Ingredient[]
                {
                    new Ingredient{IngredientNameId="kale", NamePlural="kale"},
                    new Ingredient{IngredientNameId="green", NamePlural="greens"},
                    new Ingredient{IngredientNameId="apple", NamePlural="apples"},
                    new Ingredient{IngredientNameId="cheese", NamePlural="cheese"},
                    new Ingredient{IngredientNameId="pecan", NamePlural="pecans"},
                    new Ingredient{IngredientNameId="shallot", NamePlural="shallots"},
                    new Ingredient{IngredientNameId="lemon juice", NamePlural="lemon juice"},
                    new Ingredient{IngredientNameId="apple cider vinegar", NamePlural="apple cider vinegar"},
                    new Ingredient{IngredientNameId="honey", NamePlural="honey"},
                    new Ingredient{IngredientNameId="cooking oil", NamePlural="cooking oil"},
                    new Ingredient{IngredientNameId="salt", NamePlural="salt"},
                    new Ingredient{IngredientNameId="black pepper", NamePlural="black pepper"},
                    new Ingredient{IngredientNameId="egg", NamePlural="eggs"},
                    new Ingredient{IngredientNameId="bread crumb", NamePlural="bread crumbs"},
                    new Ingredient{IngredientNameId="spaghetti sauce", NamePlural="spaghetti sauce"},
                    new Ingredient{IngredientNameId="garlic", NamePlural="garlic"},
                    new Ingredient{IngredientNameId="rosemary", NamePlural="rosemary"},
                    new Ingredient{IngredientNameId="turkey", NamePlural="turkeys"},
                    new Ingredient{IngredientNameId="beef", NamePlural="beef"},
                    new Ingredient{IngredientNameId="sausage", NamePlural="sausage"},
                    new Ingredient{IngredientNameId="chedder cheese", NamePlural="chedder cheese"},
                    new Ingredient{IngredientNameId="mozzarella cheese", NamePlural="mozzarella cheese"},
                    new Ingredient{IngredientNameId="onion", NamePlural="onion"},
                    new Ingredient{IngredientNameId="basil", NamePlural="basil"},
                    new Ingredient{IngredientNameId="tomato", NamePlural="tomatos"},
                    new Ingredient{IngredientNameId="kidney bean", NamePlural="kidney beans"},
                    new Ingredient{IngredientNameId="tomato sauce", NamePlural="tomato sauce"},
                    new Ingredient{IngredientNameId="chili powder", NamePlural="chili powder"},
                    new Ingredient{IngredientNameId="pepper", NamePlural="pepper"},
                    new Ingredient{IngredientNameId="milk", NamePlural="milk"},

                };

                foreach (Ingredient ingredient in ingredients)
                {
                    context.Ingredients.Add(ingredient);
                }
                context.SaveChanges();


                var recipies = new Recipe[]
                {
                    new Recipe{Name="Apple and Chedder Kale Salad", Picture="AppleAndChedderKaleSalad.JPG", Directions="AppleAndChedderKaleSaladDirections.txt", PrepTime="15 min", Servings="4"},
                    new Recipe{Name="Italian Style Meat Loaf", Picture="ItailianStyleMeatLoaf.JPG", Directions="ItalianStyleMeatLoafDirections.txt", PrepTime="15 min", BakeTime="30 min", Servings="6"},
                    new Recipe{Name="Chili", Picture="Chili.JPG", Directions="ChiliDirections.txt", PrepTime="20 min", BakeTime="20 min", Servings="5"}
                };

                foreach (Recipe recipe in recipies)
                {
                    context.Recipes.Add(recipe);
                }
                context.SaveChanges();


                var recipieIngredients = new RecipeIngredient[]
                {
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Apple and Chedder Kale Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i.IngredientNameId== "kale").IngredientNameId,
                        Amount = "5 cups",
                        IsIngredientNamePlural=true
                        },

                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Apple and Chedder Kale Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "green").IngredientNameId,
                        Amount = "instead of kale, optional another",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Apple and Chedder Kale Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "apple").IngredientNameId,
                        Amount = "2 small",
                        IsIngredientNamePlural=true
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Apple and Chedder Kale Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "chedder cheese").IngredientNameId,
                        Amount = "diced",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Apple and Chedder Kale Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "cheese").IngredientNameId,
                        Amount = "instead of chedder cheese, optional another",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Apple and Chedder Kale Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "pecan").IngredientNameId,
                        Amount = "toasted",
                        IsIngredientNamePlural=true
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Apple and Chedder Kale Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "shallot").IngredientNameId,
                        Amount = "finely diced",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Apple and Chedder Kale Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "lemon juice").IngredientNameId,
                        Amount = "1 Tbsp.",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Apple and Chedder Kale Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "apple cider vinegar").IngredientNameId,
                        Amount = "2 Tbsp.",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Apple and Chedder Kale Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "honey").IngredientNameId,
                        Amount = "1 Tbsp.",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Apple and Chedder Kale Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "cooking oil").IngredientNameId,
                        Amount = "1/3 cup",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Apple and Chedder Kale Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "salt").IngredientNameId,
                        Amount = "to taste",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Apple and Chedder Kale Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "black pepper").IngredientNameId,
                        Amount = "to taste",
                        IsIngredientNamePlural=true
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Italian Style Meat Loaf" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "egg").IngredientNameId,
                        Amount = "1 beaten",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Italian Style Meat Loaf" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "bread crumb").IngredientNameId,
                        Amount = "2/3 cup",
                        IsIngredientNamePlural=true
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Italian Style Meat Loaf" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "spaghetti sauce").IngredientNameId,
                        Amount = "2/3 cup",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Italian Style Meat Loaf" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "garlic").IngredientNameId,
                        Amount = "1 or 2 cloves minced",
                        IsIngredientNamePlural=true
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Italian Style Meat Loaf" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "rosemary").IngredientNameId,
                        Amount = "1/2 tsp dried",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Italian Style Meat Loaf" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "turkey").IngredientNameId,
                        Amount = "1 lb ground",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Italian Style Meat Loaf" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "beef").IngredientNameId,
                        Amount = "1 lb ground",
                        IsIngredientNamePlural=true
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Italian Style Meat Loaf" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "sausage").IngredientNameId,
                        Amount = "instead of ground turkey, optional 1 lb ground",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Italian Style Meat Loaf" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "mozzarella cheese").IngredientNameId,
                        Amount = "to put on top,",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Italian Style Meat Loaf" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "cheese").IngredientNameId,
                        Amount = "instead of mozzarella cheese, optional other",
                        IsIngredientNamePlural=true
                        },
                                        new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Chili" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "beef").IngredientNameId,
                        Amount = "1 lb ground",
                        IsIngredientNamePlural=false
                        },
                                                            new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Chili" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "onion").IngredientNameId,
                        Amount = "1 cup chopped",
                        IsIngredientNamePlural=false
                        },
                        new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Chili" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "pepper").IngredientNameId,
                        Amount = "1/2 cup chopped green",
                        IsIngredientNamePlural=false
                        },
                        new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Chili" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "garlic").IngredientNameId,
                        Amount = "2 cloves",
                        IsIngredientNamePlural=false
                        },
                        new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Chili" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "basil").IngredientNameId,
                        Amount = "1/2 tsp. dried",
                        IsIngredientNamePlural=false
                        },
                        new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Chili" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "tomato").IngredientNameId,
                        Amount = "1 14 oz can",
                        IsIngredientNamePlural=true
                        },
                        new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Chili" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "kidney bean").IngredientNameId,
                        Amount = "1 15oz can dark red",
                        IsIngredientNamePlural=true
                        },
                        new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Chili" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "tomato sauce").IngredientNameId,
                        Amount = "1 8 oz can",
                        IsIngredientNamePlural=false
                        },
                        new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Chili" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "chili powder").IngredientNameId,
                        Amount = "2-3 tsp.",
                        IsIngredientNamePlural=false
                        },
                        new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Chili" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "black pepper").IngredientNameId,
                        Amount = "1/4 tsp.",
                        IsIngredientNamePlural=false
                        },
            };

                foreach (RecipeIngredient recipeIngredient in recipieIngredients)
                {
                    context.RecipeIngredients.Add(recipeIngredient);
                }

                context.SaveChanges();
            }
        }
    }
}
