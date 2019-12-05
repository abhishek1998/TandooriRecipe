using System.Collections.Generic;
using System.Linq;
using TandooriRecipe.Models.ViewsModel;

namespace TandooriRecipe.Models {

    public class EFRecipeRepository : IRecipeRepo{
        private ApplicationDbContext context;

        public EFRecipeRepository(ApplicationDbContext ctx) {
            context = ctx;
        }

//        public IQueryable<Recipe> RecipeViewModel => context.RecipesVM;
        public IQueryable<RecipeViewModel> RecipesViewModel => context.RecipesVM; 
        public IQueryable<Recipe> Recipes => context.Recipes;
        public IQueryable<Reviews> Reviews => context.Reviews;
        public IQueryable<Ingredients> Ingredients => context.Ingredients;

        public void SaveRecipe(Recipe recipe, Reviews reviews, Ingredients ingredients)
        {
            if (recipe.RecipeId == 0) {
                context.Recipes.Add(recipe);
            } else {
                RecipeViewModel dbEntry = context.RecipesVM
                    .FirstOrDefault(r => r.recipeItem.RecipeId == recipe.RecipeId);
                Reviews dbEntry2 = context.Reviews
                    .FirstOrDefault(r => r.RecipeId == recipe.RecipeId);
                Ingredients dbEntry3 = context.Ingredients
                    .FirstOrDefault(r => r.RecipeId == recipe.RecipeId);
                if (dbEntry != null) {
                    dbEntry.recipeItem.Name = recipe.Name;
                    dbEntry.recipeItem.RecipeId = recipe.RecipeId;
                    dbEntry.recipeItem.Description = recipe.Description;
                    dbEntry.recipeItem.Author = recipe.Author;
                    dbEntry.recipeItem.Directions = recipe.Directions;
                    dbEntry2.ReviewDesc = reviews.ReviewDesc;
                    dbEntry3.Ingredient = ingredients.Ingredient;
                    //dbEntry2.RecipeId = recipe.RecipeId;
                    //dbEntry2.ReviewDesc = reviews.ReviewDesc;
                    //dbEntry3.RecipeId = recipe.RecipeId;
                    //dbEntry.RecipeIngredients = recipe.RecipeIngredients;
                    //dbEntry3.Ingredient = ingredients.Ingredient;
                }
            }
            context.SaveChanges();
        }

        public Recipe DeleteRecipe(int RecipeId) {
            Recipe dbEntry = context.Recipes
                .FirstOrDefault(r => r.RecipeId == RecipeId);
            if (dbEntry != null) {
                context.Recipes.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}