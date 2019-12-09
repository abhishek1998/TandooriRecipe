using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
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
        public IActionResult AddReview()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddReview(Reviews newReview)
        {
            RecipeRepository.AddReviewToRepo(newReview);
            return View("List", RecipeRepository.Response3);
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
            return View("List",repo.Recipes);
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

            Tuple<List<Ingredients>, Recipe, List<Reviews>> result = new Tuple<List<Ingredients>, Recipe, List<Reviews>>(ingredient, recipe, reviews);


            return View(result);
        }
            
        

        public IActionResult SearchView()
        {
            return View();
        }

        //[HttpGet]
        public IActionResult Search(string name, bool searchRecipe)
        {
            var searchresult =  new List<Recipe>();
            
            
            

            if (searchRecipe)
            {
                foreach (var recipe in repo.Recipes)
                {
                    if (recipe.Name.ToUpper() == name.ToUpper())
                    {
                        searchresult.Add(recipe);
                    }
                }
                foreach (var recipe in RecipeRepository.Response)
                {
                    if (recipe.Name.ToUpper() == name.ToUpper())
                    {
                        searchresult.Add(recipe);
                    }
                }
            }
            else
            {
                foreach (var recipe in repo.Ingredients)
                {
                    if(recipe.Ingredient.ToLower() == name.ToLower())
                    {
                        var id = recipe.RecipeId;
                        foreach (var item in repo.Recipes)
                        {
                            if (item.RecipeId == id)
                            {
                                searchresult.Add(item);
                            }
                        }
                    }
                }
                
            }

            return View("List", searchresult);
        }

        [Authorize]
        [HttpGet]
        public IActionResult AddFavourite()
        {
            return View("Favourite");
        }

        [HttpPost]
        public IActionResult AddFavourite(Favourite newFavourite)
        {
            RecipeRepository.AddFavToRepo(newFavourite);
            return View("ListF", repo.Favourites);
        }

        public Favourite getFavourite(int id)
        {
            Favourite result = null;

            foreach (var item in repo.Favourites)
            {
                if (id == item.RecipeId)
                {
                    result = item;
                    break;
                }
            }

            return result;
        }

        public ViewResult ListF(int id)
        {
            var recipe = getRecipe(id);
            var ingredient = getIngredient(id);
            var reviews = getReviews(id);
            var favs = getFavourite(id);
            return View(RecipeRepository.Response2);
        }


        public IActionResult About()
        {
            ViewData["Message"] = " WebApp to learn about various Tandoori Oven Recipe ";
            return View();
        }

    }
}