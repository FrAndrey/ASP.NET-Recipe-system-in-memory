﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asgn2.Models;

namespace asgn2.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index() => View("Home");

        public ViewResult RecipeList()
        {
            return View(Repository.Recipes);
        }

        [HttpGet]
        public ViewResult AddRecipe() => View();

        [HttpPost]
        public ViewResult AddRecipe(Recipes guestRecipe)
        {
            Repository.AddResponse(guestRecipe);
            return View("Home");
        }

        public ViewResult ViewRecipe(int id)
        {
            return View(Repository.Recipes 
                .Where(r=> r.RecipeID == id)
                );
        }




        public ViewResult ReviewRecipe() => View();
        


    }
}
