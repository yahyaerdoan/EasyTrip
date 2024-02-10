using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyTrip.Models.Contexts;
using EasyTrip.Models.Entities;

namespace EasyTrip.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        EasyTripContext easyTripContext = new EasyTripContext();
        Comment comment = new Comment();
        public ActionResult Index()
        {
            //var values = easyTripContext.Blogs.ToList();
            comment.BlogValue = easyTripContext.Blogs.ToList();
            comment.BlogValue = easyTripContext.Blogs.OrderByDescending(b => b.BlogId).Take(2);
            return View(comment);
        }
        
        public ActionResult BlogDetail(int id)        
        {           
            comment.BlogValue = easyTripContext.Blogs.Where(b => b.BlogId == id).ToList();            
            comment.CommentValue = easyTripContext.Comments.Where(c => c.BlogId == id).ToList();            
            return View(comment);
        }
    }
}