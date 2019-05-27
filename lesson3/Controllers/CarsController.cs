using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lesson3.Models;

namespace lesson3.Controllers
{
    public class CarsController : Controller
    {
        List<Cars> carList = new List<Cars>()
        {
            new Cars {Id = 1, Brand = "Chrysler", Model = "300s", Type = "Luxury Sedan", Year = 2016 },
            new Cars {Id = 2, Brand = "Hyundai", Model = "Veloster", Type = "Hatchback", Year = 2013 },
            new Cars {Id = 3, Brand = "Dodge", Model = "Charger", Type = "Sedan", Year = 2017 }
        };
    
    


        // GET: Cars
        public ActionResult Index()
        {
            return View(carList);
        }


        // GET: Cars/Details - Single Car
        public ActionResult Details (int? id)
        {
            if (id == null || id > carList.Count)
            {
                return Content("Invalid car id");

            }
            var ind = Convert.ToInt32(id) - 1;
            var car = carList[ind];

            return View(car);

        }



    }
}