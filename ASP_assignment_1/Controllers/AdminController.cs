using asgn2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asgn2.Controllers
{
    public class AdminController : Controller
    {
        private IRecipeRepository repository;

        public AdminController(IRecipeRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index()
        {
            return View(repository.Recipes);
        }
        [HttpGet]
        public ViewResult Edit(int id) => View(repository.Recipes
            .Where(o => o.RecipeID == id)
            .FirstOrDefault()
            );

        [HttpPost]
        public IActionResult Edit(Recipes adminUpdate)
        {
           repository.UpdateRecipe(adminUpdate);
            TempData["message"] = $"{adminUpdate.Name} has been saved";
            return RedirectToAction("Index");

        }



  }
}
