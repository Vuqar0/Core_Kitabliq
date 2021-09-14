using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_Kitabliq.Models;

namespace Core_Kitabliq.ViewConponents
{
    public class YeniKitablar: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var kitablistesi = new List<Kitablar>
            {
                new Kitablar
                {
                    ID= 4,
                    Kitab_AD="QORXU",
                    Kitab_yazar= "ZWEIG"
                },
               new Kitablar
               {
                   ID=5,
                   Kitab_AD= "Anna Karanina",
                   Kitab_yazar= "Lev Tolstoy"
               }
            };
            return View(kitablistesi);
        }
    }
}
