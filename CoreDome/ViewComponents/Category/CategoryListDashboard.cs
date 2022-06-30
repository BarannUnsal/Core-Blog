using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDome.ViewComponents.Category
{
    public class CategoryListDashboard : ViewComponent
    {
        CategoryManager categoryManager;

        public CategoryListDashboard(CategoryManager categoryManager)
        {
            this.categoryManager = categoryManager;
        }

        public IViewComponentResult Invoke()
        {
            var values = categoryManager.GetAllList();
            return View(values);
        }
    }
}
