using Microsoft.AspNetCore.Mvc;

namespace gastronomy_CoreProject.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
