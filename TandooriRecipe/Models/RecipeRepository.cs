using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TandooriRecipe.Models
{
    public static  class RecipeRepository 
    {
        private static readonly List<Recipe> RecipeList = new List<Recipe>();
        
        public static IEnumerable<Recipe> Response => RecipeList;

        public static void AddRecipeToRepo(Recipe newRecipe)
        {
            RecipeList.Add(newRecipe);
        }
    }
}