using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeFinder.Models;
using Microsoft.EntityFrameworkCore;

namespace RecipeFinder.Data
{
    public class RecipeFinderContext : DbContext
    {
        public RecipeFinderContext(DbContextOptions<RecipeFinderContext> options) : base(options) { }
        public DbSet<Recipe> Recipes { get; set; }        
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().ToTable("Recipe");            
            modelBuilder.Entity<Ingredient>().ToTable("Ingredient");
            modelBuilder.Entity<RecipeIngredient>().ToTable("RecipeIngredient")
                .HasKey(ri => new { ri.RecipeId, ri.IngredientNameId });


        }
    }
}
