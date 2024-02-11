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

        public PartialViewResult ReadMorePartial()
        {
            var values = easyTripContext.Blogs.OrderByDescending(b => b.BlogId).Take(3).ToList();
            return PartialView(values);
        } 

        public PartialViewResult Top10BlogPartial()
        {
            var values = easyTripContext.Blogs.ToList();
            return PartialView(values);
        }

        public PartialViewResult OurBestPlacesPartial()
        {
            var values = easyTripContext.Blogs.Take(6).ToList();
            return PartialView(values);
        }
    }
}