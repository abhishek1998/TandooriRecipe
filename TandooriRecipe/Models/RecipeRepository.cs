using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TandooriRecipe.Models
{
    public static  class RecipeRepository 
    {
        private static readonly List<Recipe> RecipeList = new List<Recipe>();

        private static readonly List<Favourite> FavouritesList = new List<Favourite>();

        private static readonly List<Reviews> ReviewsList = new List<Reviews>();

        public static IEnumerable<Recipe> Response => RecipeList;

        public static IEnumerable<Favourite> Response2 => FavouritesList;
        public static IEnumerable<Reviews> Response3 => ReviewsList;

        public static void AddRecipeToRepo(Recipe newRecipe)
        {
            RecipeList.Add(newRecipe);
        }

        public static void AddFavToRepo(Favourite newFavourite)
        {
            FavouritesList.Add(newFavourite);
        }

        public static void AddReviewToRepo(Reviews newReview)
        {
            ReviewsList.Add(newReview);
        }
    }
}