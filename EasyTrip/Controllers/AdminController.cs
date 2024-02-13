using EasyTrip.Models.Contexts;
using EasyTrip.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTrip.Controllers
{
  
    public class AdminController : Controller
    {
        // GET: Admin
        EasyTripContext easyTripContext = new EasyTripContext();
        public ActionResult Index()
        {
            var values = easyTripContext.Blogs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateNewBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNewBlog(Blog blog)
        {
            easyTripContext.Blogs.Add(blog);
            easyTripContext.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult DeleteBlog(int id)
        {
           var value = easyTripContext.Blogs.Find(id);
            easyTripContext.Blogs.Remove(value);
            easyTripContext.SaveChanges();
            return RedirectToAction("Index");
        }
       
        public ActionResult CallUpdateBlog(int id)
        {
            var value = easyTripContext.Blogs.Find(id);
            return View("CallUpdateBlog", value);
        }

        public ActionResult UpdateBlog(Blog blog)
        {
            var value = easyTripContext.Blogs.Find(blog.BlogId);
            value.Title = blog.Title;
            value.Description = blog.Description;
            value.Date = blog.Date;
            value.ImageUrl = blog.ImageUrl;
            easyTripContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}