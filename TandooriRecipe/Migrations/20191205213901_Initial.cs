using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TandooriRecipe.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecipesVM",
                columns: table => new
                {
                    RecipeViewModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipesVM", x => x.RecipeViewModelId);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RecipeId = table.Column<int>(nullable: false),
                    Ingredient = table.Column<string>(nullable: true),
                    RecipeViewModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientId);
                    table.ForeignKey(
                        name: "FK_Ingredients_RecipesVM_RecipeViewModelId",
                        column: x => x.RecipeViewModelId,
                        principalTable: "RecipesVM",
                        principalColumn: "RecipeViewModelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeViewModelId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    RecipeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Directions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                    table.ForeignKey(
                        name: "FK_Recipes_RecipesVM_RecipeViewModelId",
                        column: x => x.RecipeViewModelId,
                        principalTable: "RecipesVM",
                        principalColumn: "RecipeViewModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    RecipeViewModelId = table.Column<int>(nullable: false),
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RecipeId = table.Column<int>(nullable: false),
                    ReviewDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_RecipesVM_RecipeViewModelId",
                        column: x => x.RecipeViewModelId,
                        principalTable: "RecipesVM",
                        principalColumn: "RecipeViewModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_RecipeViewModelId",
                table: "Ingredients",
                column: "RecipeViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_RecipeViewModelId",
                table: "Recipes",
                column: "RecipeViewModelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RecipeViewModelId",
                table: "Reviews",
                column: "RecipeViewModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "RecipesVM");
        }
    }
}
