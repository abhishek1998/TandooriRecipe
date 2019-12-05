using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace TandooriRecipe.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder services)
        {
            ApplicationDbContext context = services.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                    new RecipeModel()
                    {
//                        RecipeId = 1,
//                        RecipeModelID = 1,
//                        TimeRequired = 20,
                        Name = "Dal Makhani (Indian lentils)",
                        Author = "Kana",
                        Description =
                            "Ever go to an Indian restaurant and wonder how they make those lentils? I hated " +
                            "lentils before I discovered Indian food. Then I scoured the internet to figure out " +
                            "how they achieved them, and through mixing and matching recipes and methods on videos, " +
                            "I've arrived at this recipe, which I think is pretty close. This version is very rich," +
                            " but you can leave out the cream to make it lighter. Kasuri methi (fenugreek leaves) is " +
                            "almost impossible to find in the U.S., even in NYC, but it gives this dish something very special.",
                        RecipeIngredients = new List<Ingredients>()
                        {
                            new Ingredients() {
                                Ingredient = "Lentils"
                            },
                            new Ingredients() {
                                Ingredient = "Dry Kidney Beans"
                            },
                            new Ingredients() {
                                Ingredient = "Vegetable Oil"
                            },
                            new Ingredients() {
                                Ingredient = "Cumin Seed"
                            },
                            new Ingredients() {
                                Ingredient = "Bay Leaves"
                            },
                            new Ingredients() {
                                Ingredient = "Whole Cloves"
                            },
                            new Ingredients() {
                                Ingredient = "Ground Turmeric"
                            },
                            new Ingredients() {
                                Ingredient = "Cayenne Pepper"
                            },
                        },
                        Directions =
                        "Place lentils and kidney beans in a large bowl; cover with plenty of water. Soak for at least 2 hours or overnight. Drain. " +
                        "Cook lentils, kidney beans, 5 cups water, and salt in a pot over medium heat until tender, stirring occasionally, about 1 hour. " +
                        "Remove from heat and set aside. Keep the lentils, kidney beans, and any excess cooking water in the pot. " +
                        "Heat vegetable oil in a saucepan over medium-high heat. Cook cumin seeds in the hot oil until they begin to pop, 1 to 2 minutes. " +
                        "Add cardamom pods, cinnamon stick, bay leaves, and cloves; cook until bay leaves turn brown, about 1 minute. Reduce heat to medium-low; " +
                        "add ginger paste, garlic paste, turmeric, and cayenne pepper. Stir to coat." +
                        "Stir tomato puree into spice mixture; cook over medium heat until slightly reduced, about 5 minutes. Add chili powder, coriander, and butter; " +
                        "cook and stir until butter is melted. " +
                        "Stir lentils, kidney beans and any leftover cooking water into tomato mixture; bring to a boil, reduce heat to low. " +
                        "Stir fenugreek into lentil mixture. Cover saucepan and simmer until heated through, stirring occasionally, about 45 minutes. " +
                        "Add cream and cook until heated through, 2 to 4 minutes. ",
                        ReviewsDescription =  new List<Reviews>()
                    {

                        
                        new Reviews() {

                        ReviewDesc = "This food is good"
                        }
                    }
                    },

            new RecipeModel()
                {
//                    RecipeId = 2,
//                    RecipeModelID = 2,
//                    TimeRequired = 20,
                    Name = "Keema Aaloo",
                    Author = "Kana",
                    Description =
                        "Ever go to an Indian restaurant and wonder how they make those lentils? I hated " +
                        "lentils before I discovered Indian food. Then I scoured the internet to figure out " +
                        "how they achieved them, and through mixing and matching recipes and methods on videos, " +
                        "I've arrived at this recipe, which I think is pretty close. This version is very rich, " +
                        "but you can leave out the cream to make it lighter. Kasuri methi (fenugreek leaves) " +
                        "is almost impossible to find in the U.S., even in NYC, but it gives this dish something very special. ",
                    Directions =
                        "Heat olive oil in a large saucepan over medium-high heat. Cook and stir onion in the hot oil until soft and beginning to brown, about 12 minutes. " +
                        "If browned bits of onion are stuck to the bottom of the pan, stir water into onion and stir to loosen the browned bits. " +
                        "Mix ground beef, garlic, ginger, serrano chile, and cilantro into pan; cook and stir until beef is browned and crumbly, 10 to 15 minutes. " +
                        "Reduce heat to medium-low. Stir coriander, salt, cumin, cayenne pepper, and turmeric into the beef; cook and stir until flavors blend, about 5 minutes. " +
                        "Add tomatoes and potatoes, cover pot, and simmer until potatoes are tender, about 15 minutes. " +
                        "Mix green peas into dish and cook until sauce has slightly thickened and flavors have blended, 10 to 15 minutes." +
                        " Sprinkle garam masala over the dish, cover, and let stand for 5 minutes before serving. ",

                    ReviewsDescription =  new List<Reviews>()
                    {
                        //5,
                        //8,
                        //2,
                        //5,

                        new Reviews() {

                        ReviewDesc = "This food is good"
                        },

                        new Reviews() {

                        ReviewDesc = "This food is okay"
                        },

                        new Reviews() {

                        ReviewDesc = "This food is terrible" 
                        },
                    },
                    RecipeIngredients = new List<Ingredients>()
                        {
                            new Ingredients() {
                                Ingredient = "Lentils"
                            },
                            new Ingredients() {
                                Ingredient = "Dry Kidney Beans"
                            },
                            new Ingredients() {
                                Ingredient = "Vegetable Oil"
                            },
                            new Ingredients() {
                                Ingredient = "Cumin Seed"
                            },
                            new Ingredients() {
                                Ingredient = "Bay Leaves"
                            },
                            new Ingredients() {
                                Ingredient = "Whole Cloves"
                            },
                            new Ingredients() {
                                Ingredient = "Ground Turmeric"
                            },
                            new Ingredients() {
                                Ingredient = "Cayenne Pepper"
                            },
                        },
                //                    Ingredients =
                //                        "Lentils" +
                //                        "Dry Kidney Beans" +
                //                        "Vegetable Oil" +
                //                        "Cumin Seed" +
                //                        "Bay Leaves" +
                //                        "Whole Cloves" +
                //                        "Ground Turmeric" +
                //                        "Cayenne Pepper",

            }
                );
            context.SaveChanges();
        }
    }
}
}