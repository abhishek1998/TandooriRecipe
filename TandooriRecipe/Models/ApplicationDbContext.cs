using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using TandooriRecipe.Models.ViewsModel;

namespace TandooriRecipe.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        
        public DbSet<RecipeViewModel> RecipesVM { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Favourite> Favourites { get; set; }


    }
}