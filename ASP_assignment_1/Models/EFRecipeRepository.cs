using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asgn2.Models
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private ApplicationDbContext context;

        public  EFRecipeRepository (ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Recipes> Recipes => context.Recipes;
  


    }
}
