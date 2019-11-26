using System.Collections.Generic;
using System.Linq;

namespace TandooriRecipe.Models {

    public class EFRecipeRepository : IRecipeRepo{
        private ApplicationDbContext context;

        public EFRecipeRepository(ApplicationDbContext ctx) {
            context = ctx;
        }

        public IQueryable<RecipeModel> Recipes => context.Recipes;

        public void SaveRecipe(RecipeModel recipe)
        {
            if (recipe.RecipeId == 0) {
                context.Recipes.Add(recipe);
            } else {
                RecipeModel dbEntry = context.Recipes
                    .FirstOrDefault(r => r.RecipeId == recipe.RecipeId);
                if (dbEntry != null) {
                    dbEntry.Name = recipe.Name;
                    dbEntry.RecipeId = recipe.RecipeId;
                    dbEntry.Description = recipe.Description;
                    dbEntry.Author = recipe.Author;
                    dbEntry.Directions = recipe.Directions;
                }
            }
            context.SaveChanges();
        }

        public RecipeModel DeleteRecipe(int RecipeId) {
            RecipeModel dbEntry = context.Recipes
                .FirstOrDefault(r => r.RecipeId == RecipeId);
            if (dbEntry != null) {
                context.Recipes.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}