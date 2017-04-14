using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;
using CheeseMVC.Data;

namespace CheeseMVC.Controllers
{
    public class CategoryController
    {
        private readonly CheeseDbContext context;

        public CategoryController(CheeseDbContext dbContext)
        {
            context = dbContext;
        }


        public IActionResult Index()
        {
            List<Cheese> cheeses = context.Cheeses.ToList();
            context.Categories.ToList();
            return View();
            
        }


    }

    
}
