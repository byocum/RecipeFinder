using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeFinder.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    IngredientNameId = table.Column<string>(maxLength: 25, nullable: false),
                    NamePlural = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.IngredientNameId);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    RecipeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Picture = table.Column<string>(maxLength: 50, nullable: false),
                    Directions = table.Column<string>(maxLength: 50, nullable: false),
                    PrepTime = table.Column<string>(maxLength: 15, nullable: true),
                    BakeTime = table.Column<string>(maxLength: 15, nullable: true),
                    Servings = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.RecipeId);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredient",
                columns: table => new
                {
                    RecipeId = table.Column<int>(nullable: false),
                    IngredientNameId = table.Column<string>(nullable: false),
                    Amount = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredient", x => new { x.RecipeId, x.IngredientNameId });
                    table.ForeignKey(
                        name: "FK_RecipeIngredient_Ingredient_IngredientNameId",
                        column: x => x.IngredientNameId,
                        principalTable: "Ingredient",
                        principalColumn: "IngredientNameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredient_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredient_IngredientNameId",
                table: "RecipeIngredient",
                column: "IngredientNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeIngredient");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Recipe");
        }
    }
}
