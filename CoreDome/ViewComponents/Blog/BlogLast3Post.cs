using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDome.ViewComponents.Blog
{
    public class BlogLast3Post : ViewComponent
    {
        BlogManager blogManager;

        public BlogLast3Post(BlogManager blogManager)
        {
            this.blogManager = blogManager;
        }

        public IViewComponentResult Invoke()
        {
            var values = blogManager.GetLast3Blog();
            return View(values);
        }
    }
}
