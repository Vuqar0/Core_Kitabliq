using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_Kitabliq.Models;
namespace Core_Kitabliq.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var ktp = new List<Kitablar>()
            {
                new Kitablar(){ID=1,Kitab_AD="Satranc",Kitab_yazar="Zweig"},
                new Kitablar(){ID=2,Kitab_AD="Dr ox`  deneyi",Kitab_yazar="Jules verne"},
                new Kitablar(){ID=3,Kitab_AD="Delifisek", Kitab_yazar="Vasconceulos"}
            };
            return View(ktp);
        }
    }
}
