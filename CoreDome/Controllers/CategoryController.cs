using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDome.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryManager _categoryManager;

        public CategoryController(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public IActionResult Index()
        {
            var values = _categoryManager.GetAllList();
            return View(values);
        }
    }
}
