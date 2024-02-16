using EasyTrip.Models.Contexts;
using EasyTrip.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTrip.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        EasyTripContext easyTripContext = new EasyTripContext();
        Comment comment = new Comment();
        public ActionResult Index(int id)
        {
            comment.BlogValue = easyTripContext.Blogs.Where(b => b.BlogId == id).ToList();
            comment.CommentValue = easyTripContext.Comments.Where(c => c.BlogId == id).ToList();
            return View(comment);
        }

        [HttpGet]
        public PartialViewResult DoCommentPartial(int id)
        {
            ViewBag.BlogId = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult DoCommentPartial(Comment comment)
        {
            easyTripContext.Comments.Add(comment);
            easyTripContext.SaveChanges();
            return PartialView("Index");
        }
    }
}