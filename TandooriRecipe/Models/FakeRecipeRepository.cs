using System.Collections.Generic;
using System.Linq;

namespace TandooriRecipe.Models
{
    public class FakeRecipeRepository : IRecipeRepo
    {
        public IQueryable<RecipeModel> Recipes => new List<RecipeModel>
        {
            new RecipeModel
            {
                Name = "Kadhai Kofta",
                Author = "Abhishek",
                Desciption = "Spicy Dish with potatoes"
            },
            new RecipeModel
            {
                Name = "Kadhai Kofta",
                Author = "Abhishek",
                Desciption = "Spicy Dish with potatoes"
            },
            new RecipeModel
            {
                Name = "Kadhai Kofta",
                Author = "Abhishek",
                Desciption = "Spicy Dish with potatoes"
            }
        }.AsQueryable<RecipeModel>();

        public void SaveRecipe(RecipeModel recipe)
        {
              if (recipe.RecipeId == 0) {
                context.Products.Add(recipe);
            } else {
                Product dbEntry = context.Products
                    .FirstOrDefault(p => p.RecipeId == recipe.RecipeId);
                if (dbEntry != null) {
                    dbEntry.Name = recipe.Name;
                    dbEntry.Description = recipe.Description;
                    dbEntry.Price = recipe.Price;
                    dbEntry.Category = recipe.Category;
                }
            }
            context.SaveChanges();;
        }

        public RecipeModel DeleteRecipe(int ID)
        {
            RecipeModel dbEntry = context
                .FirstOrDefault(p => p.RecipeId == productID);
            if (dbEntry != null) {
                context.Products.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;;
        }
    }
}