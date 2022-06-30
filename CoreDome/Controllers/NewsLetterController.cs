using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDome.Controllers
{
    public class NewsLetterController : Controller
    {
        private NewsLetterManager _newsLetterManager;

        public NewsLetterController(NewsLetterManager newsLetterManager)
        {
            _newsLetterManager = newsLetterManager;
        }

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter newsLetter)
        {
            newsLetter.MailStatus = true;
            _newsLetterManager.AddNewsLetter(newsLetter);
            return PartialView();
        }
    }
}
