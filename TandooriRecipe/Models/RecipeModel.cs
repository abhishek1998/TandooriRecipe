using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("RecipeId")]
        public ICollection<Reviews> ReviewsDescription { get; set; }
        [ForeignKey("RecipeId")]
        public ICollection<Ingredients> RecipeIngredients { get; set; }


    }

    public class Reviews {
        [Key]
        public int ReviewId { get; set; }
        //[ForeignKey("RecipeModel")]
        public int RecipeId { get; set; }
        public RecipeModel RecipeModel { get; set; }
        public string ReviewDesc { get; set; }
    }

    public class Ingredients
    {
        [Key]
        public int IngredientId { get; set; }
        //[ForeignKey("RecipeModel")]
        public int RecipeId { get; set; }
        public RecipeModel RecipeModel { get; set; }
        public string Ingredient { get; set; }
    }
}