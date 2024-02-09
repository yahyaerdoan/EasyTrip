using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTrip.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
        public ActionResult ScriptPartial()
        {
            return View();
        }
    }
}