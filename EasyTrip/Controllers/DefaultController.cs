using EasyTrip.Models.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTrip.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        EasyTripContext easyTripContext = new EasyTripContext();
        public ActionResult Index()
        {
            var values = easyTripContext.Blogs.ToList();
            return View(values);
        }
    }
}