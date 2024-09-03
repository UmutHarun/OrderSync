using Microsoft.AspNetCore.Mvc;

namespace Web.UI.ViewComponents.AdminayoutComponents
{
    public class _AdminLayoutHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
