using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDome.ViewComponents.Blog
{
    public class WriterLastBlog : ViewComponent
    {
        private BlogManager _blogManager;

        public WriterLastBlog(BlogManager blogManager)
        {
            _blogManager = blogManager;
        }
        public IViewComponentResult Invoke()
        {
            var values = _blogManager.GetBlogListByWriter(1);
            return View(values);
        }
    }
}
