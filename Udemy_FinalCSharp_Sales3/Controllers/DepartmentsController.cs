using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Udemy_FinalCSharp_Sales3.Models;

namespace Udemy_FinalCSharp_Sales3.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Electronics" });
            list.Add(new Department { Id = 2, Name = "Fashion" });


            return View(list);
        }
    }
}