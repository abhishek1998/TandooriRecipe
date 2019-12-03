using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TandooriRecipe.Models
{
    public class RecipeModel 
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        [Key]
        public int RecipeId { get; set; }
        public string Directions { get; set; }
        public List<Reviews> ReviewsDescription { get; set; }
        public List<Ingredients> RecipeIngredients { get; set; }


    }

    public class Reviews {
        [Key]
        public int RecipeId { get; set; }
        public string ReviewDesc { get; set; }
    }

    public class Ingredients
    {
        [Key]
        public int RecipeId { get; set; }
        public string Ingredient { get; set; }
    }
}