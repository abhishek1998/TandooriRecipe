using System.Linq;

namespace TandooriRecipe.Models
{
    public class EfRecipeRepo : IRecipeRepo
    {
        private readonly ApplicationDbContext context;
        public EfRecipeRepo(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        
        public IQueryable<RecipeModel> Recipes => context.Recipes;
    }
}