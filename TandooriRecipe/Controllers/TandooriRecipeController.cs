using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TandooriRecipe.Models;

namespace TandooriRecipe.Controllers
{
    public class TandooriRecipeController : Controller
    {
        private IRecipeRepo repo;

        public TandooriRecipeController(IRecipeRepo repository)
        {
            repo = repository;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(repo.Recipes);
        }

        [Authorize]
        [HttpGet]
        public IActionResult AddRecipe()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddRecipe(RecipeModel newRecipe)
        {
            RecipeRepository.AddRecipeToRepo(newRecipe);
            return View("Index",RecipeRepository.Response);
        }

        public IActionResult DisplayRecipe(int id)
        {
            foreach (var item in RecipeRepository.Response)
            {
                if (id == item.RecipeId)
                {
                    return View(item);
                }
            }

            return View(null);
        }

        public IActionResult About()
        {
            ViewData["Message"] = " WebApp to learn about various Tandoori Oven Recipe ";
            return View();
        }
    }
}