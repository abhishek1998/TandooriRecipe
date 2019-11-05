using Microsoft.EntityFrameworkCore.Migrations;

namespace TandooriRecipe.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeModelID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Desciption = table.Column<string>(nullable: true),
                    RecipeId = table.Column<int>(nullable: false),
                    Directions = table.Column<string>(nullable: true),
                    TimeRequired = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeModelID);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    IngredientID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    RecipeModelID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.IngredientID);
                    table.ForeignKey(
                        name: "FK_Ingredient_Recipes_RecipeModelID",
                        column: x => x.RecipeModelID,
                        principalTable: "Recipes",
                        principalColumn: "RecipeModelID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_RecipeModelID",
                table: "Ingredient",
                column: "RecipeModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
