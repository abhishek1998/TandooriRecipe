using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TandooriRecipe.Models.ViewsModel
{
    public class RecipeViewModel
    {
        [Key]
        public int RecipeViewModelId { get; set; }
        public Recipe recipeItem { get; set; }
        public List<Ingredients> IngredientsItem { get; set; }
        public List<Reviews> ReviewsItem { get; set; }
//        public List<Recipe> RecipeItem { get; set; }
    }
}
