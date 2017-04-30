using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;
using CheeseMVC.Data;
using CheeseMVC.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace CheeseMVC.ViewModels
{


    

    public class AddCategoryViewModel
    {
        [Required]
        [Display(Name = "Category")]
        public string Name { get; set; }
    }
}
