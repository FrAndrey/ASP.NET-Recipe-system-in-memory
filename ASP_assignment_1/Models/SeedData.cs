using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace asgn2.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                    new Recipes
                    {
                        Name = "Crispy Chicken",
                        Description = "This is delicious chicken in bread",
                        RecipeCategory = 3,
                        Ingredients = "Chicken"
                    },
                     new Recipes
                     {
                         Name = "Salmon",
                         Description = "This is awesome Salmon",
                         RecipeCategory = 1,
                         Ingredients = "Salmon"
                     },
                      new Recipes
                      {
                          Name = "Steak",
                          Description = "This is juicy Steak with Vegetables",
                          RecipeCategory = 2,
                          Ingredients = "Angus Beef, Vegetables"
                      }
                    );
                context.SaveChanges();

            }


        }
    }
}
