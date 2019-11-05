using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TandooriRecipe.Models
{
    public class Ingredient
    {
        public string IngredientID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
