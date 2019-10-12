using System;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace TandooriRecipe.Models
{
    public class RecipeModel 
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Desciption { get; set; }

        public string imageUrl { get; set; }
        public ArrayList Ingredients { get; set; }
        public ArrayList Directions { get; set; }
        public decimal Cost { get; set; }
        public int  TimeRequired{ get; set; }
    }
}