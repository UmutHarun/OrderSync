using Microsoft.AspNetCore.Mvc;

namespace Web.UI.ViewComponents.AdminayoutComponents
{
    public class _AdminLayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
