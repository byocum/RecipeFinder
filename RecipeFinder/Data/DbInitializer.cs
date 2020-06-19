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
                    new Ingredient{IngredientNameId="flour", NamePlural="flour"},
                    new Ingredient{IngredientNameId="cornmeal", NamePlural="cornmeal"},
                    new Ingredient{IngredientNameId="sugar", NamePlural="sugar"},
                    new Ingredient{IngredientNameId="baking powder", NamePlural="baking powder"},
                    new Ingredient{IngredientNameId="salt", NamePlural="salt"},
                    new Ingredient{IngredientNameId="butter", NamePlural="butter"},
                    new Ingredient{IngredientNameId="egg", NamePlural="eggs"},
                    new Ingredient{IngredientNameId="milk", NamePlural="milk"},
                    new Ingredient{IngredientNameId="cooking oil", NamePlural="cooking oil"},
                    new Ingredient{IngredientNameId="apple", NamePlural="apples"},
                    new Ingredient{IngredientNameId="spinach", NamePlural="spinach"},
                    new Ingredient{IngredientNameId="cinnamon", NamePlural="cinnamon"},
                    new Ingredient{IngredientNameId="tomato", NamePlural="tomatoes"},
                    new Ingredient{IngredientNameId="cucumber", NamePlural="cucumbers"},
                    new Ingredient{IngredientNameId="onion", NamePlural="onions"},
                    new Ingredient{IngredientNameId="olive", NamePlural="olives"},
                    new Ingredient{IngredientNameId="feta cheese", NamePlural="feta cheese"},
                    new Ingredient{IngredientNameId="beef round steak", NamePlural="beef round steaks"},
                    new Ingredient{IngredientNameId="black pepper", NamePlural="black pepper"},
                    new Ingredient{IngredientNameId="celery", NamePlural="celery"},
                    new Ingredient{IngredientNameId="carrot", NamePlural="carrots"},
                    new Ingredient{IngredientNameId="fettuccine noodle", NamePlural="fettuccine noodles"},
                };

                foreach (Ingredient ingredient in ingredients)
                {
                    context.Ingredients.Add(ingredient);
                }
                context.SaveChanges();


                var recipies = new Recipe[]
                {
                    new Recipe{Name="Corn Bread", Picture="IMG_8431_cropped.jpg", Directions="directions.txt", PrepTime="10 min", BakeTime="15 min", Servings="8 to 10"},
                    new Recipe{Name="Greek Salad", Picture="IMG_8431_cropped.jpg", Directions="directions.txt", PrepTime="15 min", Servings="4"},
                    new Recipe{Name="Swiss Steak", Picture="IMG_8431_cropped.jpg", Directions="directions.txt", PrepTime="25 min", BakeTime="1 1/4 hours", Servings="4"}
                };

                foreach (Recipe recipe in recipies)
                {
                    context.Recipes.Add(recipe);
                }
                context.SaveChanges();


                var recipieIngredients = new RecipeIngredient[]
                {
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Corn Bread" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i.IngredientNameId== "flour").IngredientNameId,
                        Amount = "1 cup",
                        IsIngredientNamePlural=false
                        },

                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Corn Bread" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "cornmeal").IngredientNameId,
                        Amount = "3/4 cup",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Corn Bread" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "sugar").IngredientNameId,
                        Amount = "2 - 3 tablespoons",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Corn Bread" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "baking powder").IngredientNameId,
                        Amount = "1 cup",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Corn Bread" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "salt").IngredientNameId,
                        Amount = "3/4 teaspoon",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Corn Bread" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "butter").IngredientNameId,
                        Amount = "1 tablespoon",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Corn Bread" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "egg").IngredientNameId,
                        Amount = "2 beaten",
                        IsIngredientNamePlural=true
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Corn Bread" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "milk").IngredientNameId,
                        Amount = "1 cup",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Corn Bread" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "cooking oil").IngredientNameId,
                        Amount = "1/4 cup",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Greek Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "tomato").IngredientNameId,
                        Amount = "3 medium cut into wedges",
                        IsIngredientNamePlural=true
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Greek Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "cucumber").IngredientNameId,
                        Amount = "1 medium halved lenghwise and thinly sliced",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Greek Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "onion").IngredientNameId,
                        Amount = "1 small cut into thin wedges",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Greek Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "olive").IngredientNameId,
                        Amount = "8 to 10 pitted",
                        IsIngredientNamePlural=true
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Greek Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "feta cheese").IngredientNameId,
                        Amount = "1/2 cup crumbled",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Greek Salad" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "flour").IngredientNameId,
                        Amount = "1 cup",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Swiss Steak" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "beef round steak").IngredientNameId,
                        Amount = "1 pound boneless cut 3/4 inch thick",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Swiss Steak" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "salt").IngredientNameId,
                        Amount = "1/4 teaspoon",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Swiss Steak" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "black pepper").IngredientNameId,
                        Amount = "1/4 teaspoon",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Swiss Steak" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "cooking oil").IngredientNameId,
                        Amount = "1 tablespoon",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Swiss Steak" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "tomato").IngredientNameId,
                        Amount = "1 14 1/2 ounce can diced",
                        IsIngredientNamePlural=true
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Swiss Steak" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "onion").IngredientNameId,
                        Amount = "1 small sliced and separated into rings",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Swiss Steak" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "celery").IngredientNameId,
                        Amount = "1/2 cup sliced",
                        IsIngredientNamePlural=false
                        },
                    new RecipeIngredient {
                        RecipeId = recipies.Single(r => r.Name == "Swiss Steak" ).RecipeId,
                        IngredientNameId = ingredients.Single(i => i. IngredientNameId== "fettuccine noodle").IngredientNameId,
                        Amount = "2 cups cooked",
                        IsIngredientNamePlural=true
                        }
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
