using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace asgn2.Models
{
    public class Recipes
    {
       [Key]
        public int RecipeID { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }

        public string Description { get; set; }

        public string imagePath { get; set; }

        public int RecipeCategory { get; set; }
    }
}
