using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asgn2.Models
{
    public class Repository
    {
        private static IQueryable<Recipes> recipes;


          public static IQueryable<Recipes> Recipes => new List<Recipes>
          {

              new Recipes {RecipeID =1, Name = "Salmon",Ingredients="Ssd", Description="Blabla"},
              new Recipes {RecipeID =2, Name = "Chicken",Ingredients="Ssd", Description="Ulala"},
              new Recipes {RecipeID =3, Name = "Duck",Ingredients="Ssd", Description="Mak"}
          }.AsQueryable<Recipes>(); 

        





        public static void AddResponse(Recipes guestRecipe)
        {
            recipes.ToList().Add(guestRecipe);
            foreach (var b in Recipes)
            {
                Console.WriteLine();
            }


        }






    }
}
