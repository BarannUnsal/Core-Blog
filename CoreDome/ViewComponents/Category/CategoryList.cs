using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDome.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        CategoryManager _categoryManager;

        public CategoryList(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }
        public IViewComponentResult Invoke()
        {
            var values = _categoryManager.GetAllList();
            return View(values);
        }
    }
}
