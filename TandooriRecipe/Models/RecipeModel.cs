using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace TandooriRecipe.Models
{
    public class Ingredient
    {
        public string Name  { get; set; }
        public int Quantity{ get; set; }
    }
    public class RecipeModel 
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Desciption { get; set; }
        public int RecipeId { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public String Directions { get; set; }
        public int  TimeRequired{ get; set; }
    }
}