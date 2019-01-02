using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PP.Models;

namespace PP.Controllers
{
    public class productcontroller : Controller
    {
        public IActionResult Index()
        {
        products p = new products
        {
            a = 125,
            b = "55555"
        };
            return View(p);
        }
        
    }
}