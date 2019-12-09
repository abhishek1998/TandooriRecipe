using System.Linq;
using TandooriRecipe.Models.ViewsModel;

namespace TandooriRecipe.Models
{
    public interface IRecipeRepo
    {
        IQueryable<RecipeViewModel> RecipesViewModel { get; }
        IQueryable<Recipe> Recipes { get; }
        IQueryable<Reviews> Reviews { get; }
        IQueryable<Ingredients> Ingredients { get; }
        IQueryable<Favourite> Favourites { get; }



        void SaveRecipe(Recipe recipe, Reviews reviews, Ingredients ingredients);
        void AddFavourite(Recipe recipe, Favourite favourite);
        Recipe DeleteRecipe(int ID);
    }
}