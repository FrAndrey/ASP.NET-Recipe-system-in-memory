﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asgn2.Models
{
    public interface IRecipeRepository
    {
        IEnumerable<Recipes> Recipes { get; }

    }


    public static void AddResponse(Recipes guestRecipe)
    {
        allRecipes.Add(guestRecipe);

    }
}