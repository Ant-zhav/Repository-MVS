using Complex742.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Complex742.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}