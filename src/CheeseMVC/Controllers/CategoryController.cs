using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;
using Microsoft.EntityFrameworkCore;
using CheeseMVC.Data;


namespace CheeseMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CheeseDbContext context;

        public CategoryController(CheeseDbContext dbContext)
        {
            context = dbContext;               
        }

        
        public IActionResult Index()
        {
            List<CheeseCategory> categories = context.Categories.ToList();
            return View(categories);
            
        }

        public IActionResult Add()
        {
            AddCategoryViewModel addCategoryViewModel = new AddCategoryViewModel();
            return View(addCategoryViewModel);
        }


        [HttpPost]
        public IActionResult Add(AddCategoryViewModel addCategoryViewModel)
        {

            if (ModelState.IsValid)
            {
                var theName = addCategoryViewModel.Name;
                CheeseCategory newCategory = new CheeseCategory
                {
                    Name = theName
                };
                context.Categories.Add(newCategory);
                context.SaveChanges();
                return Redirect("/Category");          
            }

            return View(addCategoryViewModel);

        }


        
        


    }

    

    
}
