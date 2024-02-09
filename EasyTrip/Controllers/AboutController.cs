using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyTrip.Models.Contexts;
using EasyTrip.Models.Entities;

namespace EasyTrip.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        EasyTripContext easyTripContext = new EasyTripContext();
        public ActionResult Index()
        {
            var values = easyTripContext.Abouts.ToList();
            return View(values);
        }
    }
}