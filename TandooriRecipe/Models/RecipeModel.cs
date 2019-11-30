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
//        public string Ingredients { get; set; }
        public string Directions { get; set; }
//        public int  TimeRequired{ get; set; }
    }
}