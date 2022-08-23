using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Store.Web.Models;
using Store.Domain.Products;

namespace Store.Web.Controllers
{
    public class CategoryController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateOrEdit()
        {
            return View();
        }


        [HttpPost]
        public  IActionResult CreateOrEdit(Category model)
        {
            return View();
        }


    }
}
