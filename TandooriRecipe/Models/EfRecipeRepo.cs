using System.Collections.Generic;
using System.Linq;

namespace TandooriRecipe.Models {

    public class EFRecipeRepository : IRecipeRepo{
        private ApplicationDbContext context;

        public EFRecipeRepository(ApplicationDbContext ctx) {
            context = ctx;
        }

        public IQueryable<RecipeModel> Recipes => context.Recipes;

        public void Save(RecipeModel recipe) {
            if (recipe.RecipeId == 0) {
                context.Recipes.Add(recipe);
            } else {
                RecipeModel dbEntry = context.Recipes
                    .FirstOrDefault(r => r.RecipeId == recipe.RecipeId);
                if (dbEntry != null) {
                    dbEntry.Name = recipe.Name;
                    dbEntry.Description = recipe.Description;
                    //dbEntry.Price = recipe.Price;
                    dbEntry.Author = recipe.Author;
                }
            }
            context.SaveChanges();
        }

        public RecipeModel DeleteProduct(int RecipeId) {
            RecipeModel dbEntry = context.Recipes
                .FirstOrDefault(r => r.RecipeId == RecipeId);
            if (dbEntry != null) {
                context.Recipes.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
                public void SaveRecipe(RecipeModel recipe)
                {
                    throw new System.NotImplementedException();
                }
        
                public RecipeModel DeleteRecipe(int ID)
                {
                    throw new System.NotImplementedException();
                }
    }
}