using System.Collections;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TandooriRecipe.Models;

namespace TandooriRecipe.Controllers
{
    public class TandooriRecipeController : Controller
    {
        public IActionResult Index()
        {
            return View(RecipeRepository.Response.Where(r=> r.Name != null) );
        }

//        [HttpGet]
//        public IActionResult AddRecipe()
//        {
//            return View("Index");
//        }
        
        [HttpPost]
        public IActionResult AddRecipe(RecipeModel newRecipe)
        {
            RecipeRepository.AddRecipeToRepo(newRecipe);
            return View("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = " WebApp to learn about various Tandoori Oven Recipe ";
            return View();
        }
    }
}