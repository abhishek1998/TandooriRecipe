using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TandooriRecipe.Models;

namespace TandooriRecipe.Controllers
{
    public class AdminController : Controller
    {
        private IRecipeRepo repo;

        public AdminController(IRecipeRepo repository)
        {
            repo = repository;
        }

        public ViewResult Index() => View(repo.Recipes);

        public ViewResult Edit(int id) => View(repo.Recipes.FirstOrDefault(r => r.RecipeId == id));

        [HttpPost]
        public IActionResult Edit(RecipeModel recipe)
        {
            if (ModelState.IsValid)
            {
                repo.SaveRecipe(recipe);
                TempData["message"] = $"{recipe.Name} has been saved.";
                return RedirectToAction("Index");
            }
            else
            {
                return View(recipe);
            }
        }

        public ViewResult Create() => View("Edit", new RecipeModel());


        [HttpPost]
        public IActionResult Delete(int id)
        {
            RecipeModel delete_recipe = repo.DeleteRecipe(id);
            if (delete_recipe != null)
            {
                TempData["message"] = $"{delete_recipe.Name} has been deleted ";
            }

            return RedirectToAction("Index");
        }
    }
}