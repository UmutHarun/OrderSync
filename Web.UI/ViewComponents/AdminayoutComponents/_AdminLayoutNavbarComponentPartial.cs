using Microsoft.AspNetCore.Mvc;

namespace Web.UI.ViewComponents.AdminayoutComponents
{
    public class _AdminLayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
