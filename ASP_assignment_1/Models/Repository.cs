using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace asgn2.Models
{
    public class Repository : IRecipeRepository
    {
        public IEnumerable<Recipes> Recipes => new List<Recipes>
        { 
              new Recipes {RecipeID=0, Name="Salmon",Ingredients="Salmon, rice, lemon",Description="Put fish in the oven for 30 minutes",imagePath="~/pictures/salmon.jpg"},
              new Recipes {RecipeID=1, Name = "Chicken",Ingredients="Chicken, spices, marinade mix", Description="Bake 45 mins",imagePath="~/pictures/chiken.png"},
              new Recipes {RecipeID=2, Name = "Duck",Ingredients="Duck, grapefruit, potatoes", Description="Bake at least 1 hour",imagePath="~/pictures/duck.jpg"}
        };
              









    }
}
