
using HomeBudgetDemo.Models;
using HomeBudgetDemo.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult ViewIncome()
        {
            return View();
        }

        public IActionResult ViewCosts()
        {
            return View();
        }

        public IActionResult AddCost()
        {
            return View();
        }
        public IActionResult AddIncome()
        {
            return View();
        }

    }
}
