using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asgn2.Models
{
    public static class Repository
    {


        private static List<Recipes> allRecipes = new List<Recipes>()
        {
              new Recipes {RecipeID=0, Name="Salmon",Ingredients="Ssd",Description="Blabla",imagePath="~/pictures/salmon.jpg"},
              new Recipes {RecipeID=1, Name = "Chicken",Ingredients="Ssd", Description="Ulala"},
              new Recipes {RecipeID=2, Name = "Duck",Ingredients="Ssd", Description="Mak"}
        };


        
             
            

        
        public static IEnumerable<Recipes> Recipes
        {
            get
                {
                return allRecipes;
            }
        }


        public static void AddResponse(Recipes guestRecipe)
        {
            allRecipes.Add(guestRecipe);
        
        }






    }
}
