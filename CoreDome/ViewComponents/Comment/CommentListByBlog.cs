using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDome.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager commentManager;

        public CommentListByBlog(CommentManager commentManager)
        {
            this.commentManager = commentManager;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.GetAllComment(id);
            return View(values);
        }
    }
}
