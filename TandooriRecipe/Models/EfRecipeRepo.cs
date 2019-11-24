using System.Collections.Generic;
using System.Linq;

namespace TandooriRecipe.Models {

    public class EFRecipeRepository : IRecipeRepo{
        private ApplicationDbContext context;

        public EFRecipeRepository(ApplicationDbContext ctx) {
            context = ctx;
        }

        public IQueryable<Product> Recipes => context.Recipes;

        public void Save(RecipeModel recipe) {
            if (recipe.ProductID == 0) {
                context.Products.Add(recipe);
            } else {
                Product dbEntry = context.Products
                    .FirstOrDefault(p => p.RecipeID== recipe.RecipeId);
                if (dbEntry != null) {
                    dbEntry.Name = recipe.Name;
                    dbEntry.Description = recipe.Description;
                    dbEntry.Price = recipe.Price;
                    dbEntry.Category = recipe.Category;
                }
            }
            context.SaveChanges();
        }

        public Product DeleteProduct(int productID) {
            Product dbEntry = context.Products
                .FirstOrDefault(p => p.ProductID == productID);
            if (dbEntry != null) {
                context.Products.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}