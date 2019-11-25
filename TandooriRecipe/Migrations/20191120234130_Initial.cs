using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;

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
                            RecipeId = table.Column<int>(type: "int", nullable: false)
                                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                            Directions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                            Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                            Author = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        },
                        constraints: table =>
                        {
                            table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                        });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");
        

        }
    }
}
