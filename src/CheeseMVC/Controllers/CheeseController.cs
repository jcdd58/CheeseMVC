﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        static private Dictionary<string, string> Cheeses = new Dictionary<string, string>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.cheeses = Cheeses;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]

        public IActionResult NewCheese(string Name, string Description)
        {
        
            Models.Cheese newCheese = new Models.Cheese();
            newCheese.Name = Name;
            newCheese.Description = Description;
            Cheeses.Add(newCheese.Name, newCheese.Description);

            return Redirect("/Cheese");
        }
    }
}
