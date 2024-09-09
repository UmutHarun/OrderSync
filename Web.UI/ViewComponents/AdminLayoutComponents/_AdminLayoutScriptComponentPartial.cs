using Microsoft.AspNetCore.Mvc;

namespace Web.UI.ViewComponents.AdminayoutComponents
{
    public class _AdminLayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
