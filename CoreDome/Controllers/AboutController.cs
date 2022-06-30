using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDome.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager;

        public AboutController(AboutManager aboutManager)
        {
            this.aboutManager = aboutManager;
        }

        public IActionResult Index()
        {
            var values = aboutManager.GetList();
            return View(values);
        }
        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
    }
}
