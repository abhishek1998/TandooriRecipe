using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TandooriRecipe.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace TandooriRecipe.Controllers {

    [Authorize]
    public class AdminController : Controller {
        private IRecipeRepo repository;

        public AdminController(IRecipeRepo repo) {
            repository = repo;
        }
        private UserManager<User> userManager;
        public AdminController(UserManager<User> usrMgr) {
            userManager = usrMgr;
        }
        // public ViewResult Index() => View(userManager.Users);
        public ViewResult Index() => View(repository.Recipes);

        public ViewResult Edit(int Id) =>
            View(repository.Recipes
                .FirstOrDefault(p => p.RecipeId== Id));
        
        [HttpPost]
        public IActionResult Edit(RecipeModel recipe) {
            if (ModelState.IsValid) {
                repository.SaveRecipe(recipe);
                TempData["message"] = $"{recipe.Name} has been saved";
                return RedirectToAction("Index");
            } else {
                // there is something wrong with the data values
                return View(recipe);
            }
        }

        public ViewResult Create() => View("Edit", new RecipeModel());

        [HttpPost]
        public IActionResult Delete(int id ) {
            RecipeModel deletedProduct = repository.DeleteRecipe(id);
            if (deletedProduct != null) {
                TempData["message"] = $"{deletedProduct.Name} was deleted";
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult SeedDatabase() {
//            SeedData.EnsurePopulated(HttpContext.RequestServices);
            return RedirectToAction(nameof(Index));
        }
    }
}