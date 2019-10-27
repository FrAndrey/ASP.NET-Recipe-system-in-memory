using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asgn2.Models
{
    public class Recipes
    {
        public int RecipeID { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }

        public string Description { get; set; }


        /*public Recipes(int RecID, string nam, string Ingred, string Descr)
        {
            RecipeID = RecID;
            Name = nam;
            Ingredients = Ingred;
            Description = Descr;

        } */

    }
}
