using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace TandooriRecipe.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        
        public DbSet<RecipeModel> Recipes { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }

    }
}