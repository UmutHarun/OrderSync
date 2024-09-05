using Microsoft.AspNetCore.Mvc;

namespace Web.UI.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
