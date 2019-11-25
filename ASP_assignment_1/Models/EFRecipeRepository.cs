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
        public void UpdateRecipe(Recipes adminUpdate)
        {
         if (adminUpdate.RecipeID == 0)
            {
                context.Recipes.Add(adminUpdate);
            }
         else
            {
                Recipes productEntry = context.Recipes.FirstOrDefault(r =>
                    r.RecipeID == adminUpdate.RecipeID);
                if (productEntry != null)
                {
                    productEntry.Name = adminUpdate.Name;
                    productEntry.Ingredients = adminUpdate.Ingredients;
                    productEntry.Description = adminUpdate.Description;
                }
            }
            context.SaveChanges();
        }
        public Recipes DeleteRecipe(int id)
        {
            Recipes productEntry = context.Recipes.FirstOrDefault(r =>
                    r.RecipeID == id);

            if (productEntry != null)
            {
                context.Recipes.Remove(productEntry);
                context.SaveChanges();
            }
            return productEntry;



            }

        }

    }

