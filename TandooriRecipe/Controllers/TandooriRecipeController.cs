using System;
using System.Collections.Generic;
using System.Dynamic;
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
            return View(repo.Recipes);
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
        public IActionResult AddRecipe(Recipe newRecipe)
        {
            RecipeRepository.AddRecipeToRepo(newRecipe);
            return View("Index",RecipeRepository.Response);
        }

        public List<Reviews> getReviews(int id )
        {
            var result = new List<Reviews>();
             
            foreach (var item in repo.Reviews)
            {
                if (id == item.RecipeId)
                {
                   result.Add(item); 
                    break;
                }
            }

            return result;
        }
        public List<Ingredients> getIngredient (int id )
        {
            var result = new List<Ingredients>();
             
            foreach (var item in repo.Ingredients)
            {
                if (id == item.RecipeId)
                {
                   result.Add(item); 
                    break;
                }
            }

            return result;
        }
        public Recipe getRecipe(int id )
        {
            Recipe result = null;
             
            foreach (var item in repo.Recipes)
            {
                if (id == item.RecipeId)
                {
                    result = item;
                    break;
                }
            }

            return result;
        }

        public IActionResult DisplayRecipe(int id)
        {
            var recipe = getRecipe(id);
            var ingredient = getIngredient(id);
            var reviews = getReviews(id);
            
            Tuple<List<Ingredients>, Recipe, List<Reviews>>  result = new Tuple<List<Ingredients>, Recipe, List<Reviews>>(ingredient,recipe,reviews);
            

            return View(result);
        }

        public IActionResult SearchView()
        {
            return View();
        }

        //[HttpGet]
        public IActionResult Search(string name)
        {
            var searchresult =  new List<Recipe>();
            name = name.ToUpper();
            foreach (var recipe in repo.Recipes)
            {
                if (recipe.Name.ToUpper() == name)
                {
                    searchresult.Add(recipe);
                }
            }
            return View("List", searchresult);
        }

        public IActionResult About()
        {
            ViewData["Message"] = " WebApp to learn about various Tandoori Oven Recipe ";
            return View();
        }

    }
}