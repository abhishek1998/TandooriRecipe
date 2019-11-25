using Microsoft.AspNetCore.Identity;

namespace TandooriRecipe.Models
{
    public class User : IdentityUser
    {
        public User(string userName) : base(userName)
        {
        }
    }
}