using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP_assignment_1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("Home");


        public ViewResult RecipeList() => View();
        public ViewResult AddRecipe() => View();
        public ViewResult ReviewRecipe() => View();
        public ViewResult ViewRecipe() => View();


    }
}
