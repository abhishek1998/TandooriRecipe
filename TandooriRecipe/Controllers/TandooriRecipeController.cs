using System.Net;
using Microsoft.AspNetCore.Mvc;
using TandooriRecipe.Models;

namespace TandooriRecipe.Controllers
{
    public class TandooriRecipeController : Controller
    {
        public IActionResult Index()
        {
            return View(RecipeRepository.Response );
        }

        [HttpGet]
        public IActionResult AddRecipe()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddRecipe(RecipeModel newRecipe)
        {
            RecipeRepository.AddRecipeToRepo(newRecipe);
            return View("Index",RecipeRepository.Response);
        }

//        [HttpGet]
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