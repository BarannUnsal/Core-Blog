using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDome.ViewComponents.Blog
{
    public class BlogListDashboard : ViewComponent
    {
        BlogManager blogManager;

        public BlogListDashboard(BlogManager blogManager)
        {
            this.blogManager = blogManager;
        }

        public IViewComponentResult Invoke()
        {
            var values = blogManager.GetBlogWithCategory();
            return View(values);
        }
    }
}
