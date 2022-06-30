using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDome.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager _writerManager;

        public WriterAboutOnDashboard(WriterManager writerManager)
        {
            _writerManager = writerManager;
        }

        public IViewComponentResult Invoke()
        {
            var values = _writerManager.GetWriterById(1);
            return View(values);
        }
    }
}
