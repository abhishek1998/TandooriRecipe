using System.Linq;

namespace TandooriRecipe.Models
{
    public interface IRecipeRepo
    {
        IQueryable<RecipeModel> Recipes { get; } 
    }
}