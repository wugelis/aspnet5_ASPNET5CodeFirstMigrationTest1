using Microsoft.AspNet.Mvc;
using System;

namespace MyCodeFiratAPNET5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}