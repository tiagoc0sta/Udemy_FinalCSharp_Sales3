using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Udemy_FinalCSharp_Sales3.Controllers
{
    public class SellersController : Controller
    { 
        public IActionResult Index()
        {
        return View();
        }
    }
}