using System.ComponentModel.DataAnnotations;

namespace TandooriRecipe.Models.ViewsModel
{
    public class LoginModel
    {
        [Required] public string Name { get; set; }
        [Required] 
//        [UIHint("password")]
        public string Password { get; set; }

        public string ReturnURL { get; set; } = "/";


    }
}