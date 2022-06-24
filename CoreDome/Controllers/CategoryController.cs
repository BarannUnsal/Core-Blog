using Microsoft.AspNetCore.Mvc;

namespace CoreDome.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
