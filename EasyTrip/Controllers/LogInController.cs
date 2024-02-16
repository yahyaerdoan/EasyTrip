using EasyTrip.Models.Contexts;
using EasyTrip.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EasyTrip.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        EasyTripContext easyTripContext = new EasyTripContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(Admin admin )
        {
            var values = easyTripContext.Admins.FirstOrDefault(a => a.UserName == admin.UserName && a.Password == admin.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                Session["UserName"] = values.UserName.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }           
        }
    }
}