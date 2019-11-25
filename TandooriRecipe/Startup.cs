using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TandooriRecipe.Models;

namespace TandooriRecipe
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(
                   Configuration["Data:TandooriRecipeApp:ConnectionString"]));
            //services.AddDbContext<AppIdentityDbContext>(options =>
            // options.UseSqlServer(
             //    Configuration["Data:Identity:ConnectionString"]));

            services.AddTransient<IRecipeRepo, EFRecipeRepository>();
            //services.AddIdentity<User, IdentityRole>()
             //   .AddEntityFrameworkStores<AppIdentityDbContext>()
               // .AddDefaultTokenProviders();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=TandooriRecipe}/{action=List}/{id?}");

                routes.MapRoute(
                    name: "AddRecipe",
                    template: "{controller=TandooriRecipe}/{action=AddRecipe}/{id?}");
            });
            SeedData.EnsurePopulated(app);
//            IdentitySeedData.EnsurePopulated( app);
        }
    }
}