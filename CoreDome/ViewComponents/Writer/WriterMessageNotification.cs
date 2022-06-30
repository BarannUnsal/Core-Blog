using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDome.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        MessageManager messageManager;

        public WriterMessageNotification(MessageManager messageManager)
        {
            this.messageManager = messageManager;
        }

        public IViewComponentResult Invoke()
        {
            string p = "deneme@gmail.com";
            var values = messageManager.GetInboxListByWriter(p);
            return View(values);
        }
    }
}
