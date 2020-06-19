using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeFinder.Migrations
{
    public partial class UpdateRecipeIngredientTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsIngredientNamePlural",
                table: "RecipeIngredient",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsIngredientNamePlural",
                table: "RecipeIngredient");
        }
    }
}
