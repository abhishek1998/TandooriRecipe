using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace TandooriRecipe.Models
{
    public static class IdentitySeedData
    {
        private const string adminUser = "Admin";
        private const string adminPassword = "Secret123$";
        private const string generalUser = "General";
        private const string generalPassword = "Hidden321#";

        public static async Task EnsurePopulated(UserManager<IdentityUser> userManager)
        {

            IdentityUser user = await userManager.FindByIdAsync(adminUser);
            IdentityUser user2 = await userManager.FindByIdAsync(generalUser);
            if (user == null)
            {
                user = new IdentityUser("Admin");
                await userManager.CreateAsync(user, adminPassword);
                user2 = new IdentityUser("General");
                await userManager.CreateAsync(user2, generalPassword);
            }
        }
    }
}