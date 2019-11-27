using Microsoft.AspNetCore.Mvc;
using TandooriRecipe.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace SportsStore.Controllers {

    [Authorize]
    public class AdminController : Controller {
        private IRecipeRepo repository;

        public AdminController(IRecipeRepo repo) {
            repository = repo;
        }

        public ViewResult Index() => View(repository.Recipes);

        public ViewResult Edit(int productId) =>
            View(repository.Recipes
                .FirstOrDefault(p => p.RecipeId== productId));
        
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
        public IActionResult Delete(int recipeId) {
            RecipeModel deletedRecipe = repository.DeleteRecipe(recipeId);
            if (deletedRecipe != null) {
                TempData["message"] = $"{deletedRecipe.Name} was deleted";
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult SeedDatabase() {
            SeedData.EnsurePopulated(HttpContext.RequestServices);
            return RedirectToAction(nameof(Index));
        }
    }
}

//using System.Linq;
//using Microsoft.AspNetCore.Mvc;
//using TandooriRecipe.Models;
//using Microsoft.AspNetCore.Identity;
//using System.Threading.Tasks;
//
//namespace TandooriRecipe.Controllers
//{
//    public class AdminController : Controller
//    {
//        private IUserValidator<AppUser> userValidator;
//        private IPasswordValidator<AppUser> passwordValidator;
//        private IPasswordHasher<AppUser> passwordHasher;
//        public AdminController(UserManager<AppUser> usrMgr,
//            IUserValidator<AppUser> userValid,
//            IPasswordValidator<AppUser> passValid,
//            IPasswordHasher<AppUser> passwordHash)
//        {
//            userManager = usrMgr;
//            userValidator = userValid;
//            passwordValidator = passValid;
//            passwordHasher = passwordHash;
//        }
//        //private IRecipeRepo repo;
//
//        //public AdminController(IRecipeRepo repository)
//        //{
//        //    repo = repository;
//        //}
//        private UserManager<AppUser> userManager;
//        public AdminController(UserManager<AppUser> mgr)
//        {
//            userManager = mgr;
//        }
//
//        public ViewResult Index() => View(userManager.Users);
//
//        public ViewResult Create() => View();
//
//        [HttpPost]
//        public async Task<IActionResult> Create(CreateModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                AppUser user = new AppUser
//                {
//                    UserName = model.Name,
//                    Email = model.Email
//                };
//
//                IdentityResult result = await userManager.CreateAsync(user, model.Password);
//
//                if (result.Succeeded)
//                {
//                    return RedirectToAction("Index");
//                }
//                else
//                {
//                    foreach(IdentityError error in result.Errors)
//                    {
//                        ModelState.AddModelError("", error.Description);
//                    }
//                }
//            }
//            return View(model);
//        }
//
//        [HttpPost]
//        public async Task<IActionResult> Delete(string id)
//        {
//            AppUser user = await userManager.FindByIdAsync(id);
//            if (user != null)
//            {
//                IdentityResult result = await userManager.DeleteAsync(user);
//                if (result.Succeeded)
//                {
//                    return RedirectToAction("Index");
//                }
//                else
//                {
//                    AddErrorsFromResult(result);
//                }
//            }
//            else
//            {
//                ModelState.AddModelError("", "User Not Found");
//            }
//            return View("Index", userManager.Users);
//        }
//        private void AddErrorsFromResult(IdentityResult result)
//        {
//            foreach (IdentityError error in result.Errors)
//            {
//                ModelState.AddModelError("", error.Description);
//            }
//        }
//        //public ViewResult Index() => View(repo.Recipes);
//
//        //public ViewResult Edit(int id) => View(repo.Recipes.FirstOrDefault(r => r.RecipeId == id));
//
//        //[HttpPost]
//        //public IActionResult Edit(RecipeModel recipe)
//        //{
//        //    if (ModelState.IsValid)
//        //    {
//        //        repo.SaveRecipe(recipe);
//        //        TempData["message"] = $"{recipe.Name} has been saved.";
//        //        return RedirectToAction("Index");
//        //    }
//        //    else
//        //    {
//        //        return View(recipe);
//        //    }
//        //}
//
//        //public ViewResult Create() => View("Edit", new RecipeModel());
//
//
//        //[HttpPost]
//        //public IActionResult Delete(int id)
//        //{
//        //    RecipeModel delete_recipe = repo.DeleteRecipe(id);
//        //    if (delete_recipe != null)
//        //    {
//        //        TempData["message"] = $"{delete_recipe.Name} has been deleted ";
//        //    }
//
//        //    return RedirectToAction("Index");
//        //}
//    }
//}