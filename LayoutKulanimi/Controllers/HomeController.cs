using LayoutKullanimi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LayoutKullanimi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()

        {
            var model = new List<Urun>()
            {
               new Urun
               {
                   Id=1,
                   UrunAdi="chai",
                   Fiyat=5
               },

               new Urun
               {
                   Id=2,
                   UrunAdi="elma",
                   Fiyat=7
               }
            };
            ViewBag.Title = "Ana Sayfa";
            return View(model);
        }
    }
}
