using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_assignment_1.Models
{
    public class Repository
    {
        private static List<Recipes> recipes = new List<Recipes>();
        public static IEnumerable<Recipes> Recipes
        {
            get
            {
                return recipes;
;
            }
        }
        public static void AddResponse(Recipes guestRecipe)
        {
            recipes.Add(guestRecipe);
        }






    }
}
