namespace TandooriRecipe.Models
{
    public class CreateUser
    {
       [System.ComponentModel.DataAnnotations.Required] 
       public string Name {get; set;}
       [System.ComponentModel.DataAnnotations.Required] 
       public string Email{get; set;}
       [System.ComponentModel.DataAnnotations.Required] 
       public string Password{get; set;}
    }
}