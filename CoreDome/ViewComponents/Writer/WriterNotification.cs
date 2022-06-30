using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDome.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        NotificationService _notificationService;

        public WriterNotification(NotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _notificationService.GetAllList();
            return View(values);
        }
    }
}
