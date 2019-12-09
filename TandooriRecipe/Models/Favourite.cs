using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TandooriRecipe.Models
{
    public class Favourite
    {
        [Key]
        public int FavouriteID { get; set; }
        public int RecipeId { get; set; }
        public String UserName { get; set; }
        public String recipeName { get; set; }
    }
}
