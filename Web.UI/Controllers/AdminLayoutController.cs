using Microsoft.AspNetCore.Mvc;

namespace Web.UI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
