using Microsoft.AspNetCore.Mvc;

namespace TandooriRecipe.Controllers
{
    public class RecipeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}