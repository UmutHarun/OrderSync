﻿using Microsoft.AspNetCore.Mvc;

namespace Web.UI.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
