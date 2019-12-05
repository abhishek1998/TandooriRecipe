using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TandooriRecipe.Models.ViewsModel
{
    public class RecipeDetails
    {
        public RecipeModel Recipevm { get; set; }
        public Ingredients Ingredientsvm { get; set; }
        public Reviews Reviewsvm { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int RecipeId { get; set; }
        public string Directions { get; set; }
        public ICollection<Reviews> ReviewsDescription { get; set; }
        public ICollection<Ingredients> RecipeIngredients { get; set; }
        ////[Key]
        //public int ReviewId { get; set; }
        ////[ForeignKey("RecipeModel")]
        //public int RecipeId { get; set; }
        //public RecipeModel RecipeModel { get; set; }
        //public string ReviewDesc { get; set; }
    }
}
