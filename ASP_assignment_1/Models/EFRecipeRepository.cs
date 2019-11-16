using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asgn2.Models
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private static ApplicationDbContext context;

        public  EFRecipeRepository (ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Recipes> Recipes => context.Recipes;


        public void AddResponse(Recipes guestRecipe)
        {
            context.Recipes.Add(guestRecipe);
            context.SaveChanges();
        }
    }
}
