using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace TandooriRecipe.Models
{
    public class RecipeModel 
    {
        [Key]
        public int id{ get; set; }
//        public int ID{ get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int RecipeId { get; set; }
//        public string Ingredients { get; set; }
        public string Directions { get; set; }
//        public int  TimeRequired{ get; set; }
    }
}