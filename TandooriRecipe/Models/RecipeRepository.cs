using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TandooriRecipe.Models
{
    public static  class RecipeRepository 
    {
        private static List<RecipeModel> RecipeList = new List<RecipeModel>();
        
        public static IEnumerable<RecipeModel> Response => RecipeList;

        public static void AddRecipeToRepo(RecipeModel newRecipe)
        {
            RecipeList.Add(newRecipe);
        }
    }
}