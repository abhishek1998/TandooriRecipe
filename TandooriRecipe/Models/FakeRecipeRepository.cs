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
    }
}