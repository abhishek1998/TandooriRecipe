using System.Linq;

namespace TandooriRecipe.Models
{
    public interface IRecipeRepo
    {
        IQueryable<RecipeModel> Recipes { get; }
        IQueryable<Reviews> Reviews { get; }
        IQueryable<Ingredients> Ingredients { get; }



        void SaveRecipe(RecipeModel recipe, Reviews reviews, Ingredients ingredients);
        RecipeModel DeleteRecipe(int ID);
    }
}