using Microsoft.AspNetCore.Mvc;

namespace Web.UI.ViewComponents.AdminayoutComponents
{
    public class _AdminLayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
