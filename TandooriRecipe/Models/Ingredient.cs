using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TandooriRecipe.Models
{
    public class Ingredient
    {
        public string IngredientID { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
    }
}
