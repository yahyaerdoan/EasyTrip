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

        public ActionResult CommentList()
        {
            var values = easyTripContext.Comments.ToList();
            return View(values);
        }

        public ActionResult DeleteComment(int id)
        {
            var value = easyTripContext.Comments.Find(id);
            easyTripContext.Comments.Remove(value);
            easyTripContext.SaveChanges();
            return RedirectToAction("CommentList");
        }

        public ActionResult CallUpdateComment(int id)
        {
            var value = easyTripContext.Comments.Find(id);
            return View("CallUpdateComment", value);
        }

        public ActionResult UpdateComment(Comment comment)
        {
            var value = easyTripContext.Comments.Find(comment.CommentId);
            value.UserName = comment.UserName;
            value.Email = comment.Email;
            value.Remark = comment.Remark;         
            easyTripContext.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}