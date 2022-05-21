using Gymzilla.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymzilla.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            var brands = new List<Brand>();
            for(var i = 1; i < 11; i++)
            {
               brands.Add(new Brand { Name = "Brand" + i.ToString() });
            }
            return View(brands);
        }
        public IActionResult ShopByBrand(string brand)
        {
            if(brand==null)
            {
                return RedirectToAction("Index");
            }
            ViewData["brand"] = brand;

            return View();
        }
        public IActionResult Create() {

            return View();
        }
    }
}
