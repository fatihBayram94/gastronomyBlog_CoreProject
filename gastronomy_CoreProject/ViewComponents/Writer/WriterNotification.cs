using Microsoft.AspNetCore.Mvc;

namespace gastronomy_CoreProject.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
      public IViewComponentResult Invoke()
      {
            return View();
      }
   
    }
}
