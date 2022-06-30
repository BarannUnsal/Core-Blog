using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDome.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager;

        public CommentController(CommentManager commentManager)
        {
            this.commentManager = commentManager;
        }

        public IActionResult Index()
        {
            return View();
        }
       
        public PartialViewResult CommentListByBlog(int id)
        {
            var values = commentManager.GetAllComment(id);
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            comment.BlogID = 2;
            commentManager.Add(comment);
            return PartialView();
        }
    }
}
