using System.Collections.Generic;
using System.Linq;

namespace TandooriRecipe.Models {

    public class EFRecipeRepository : IRecipeRepo{
        private ApplicationDbContext context;

        public EFRecipeRepository(ApplicationDbContext ctx) {
            context = ctx;
        }

        public IQueryable<RecipeModel> Recipes => context.Recipes;
        public IQueryable<Reviews> Reviews => context.Reviews;
        public IQueryable<Ingredients> Ingredients => context.Ingredients;

        public void SaveRecipe(RecipeModel recipe, Reviews reviews, Ingredients ingredients)
        {
            if (recipe.RecipeId == 0) {
                context.Recipes.Add(recipe);
            } else {
                RecipeModel dbEntry = context.Recipes
                    .FirstOrDefault(r => r.RecipeId == recipe.RecipeId);
                Reviews dbEntry2 = context.Reviews
                    .FirstOrDefault(r => r.RecipeId == recipe.RecipeId);
                Ingredients dbEntry3 = context.Ingredients
                    .FirstOrDefault(r => r.RecipeId == recipe.RecipeId);
                if (dbEntry != null) {
                    dbEntry.Name = recipe.Name;
                    dbEntry.RecipeId = recipe.RecipeId;
                    dbEntry.Description = recipe.Description;
                    dbEntry.Author = recipe.Author;
                    dbEntry.Directions = recipe.Directions;
                    dbEntry.ReviewsDescription = recipe.ReviewsDescription;
                    dbEntry2.RecipeId = recipe.RecipeId;
                    dbEntry2.ReviewDesc = reviews.ReviewDesc;
                    dbEntry3.RecipeId = recipe.RecipeId;
                    dbEntry.RecipeIngredients = recipe.RecipeIngredients;
                    dbEntry3.Ingredient = ingredients.Ingredient;
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