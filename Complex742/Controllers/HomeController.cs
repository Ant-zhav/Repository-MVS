using Complex742.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.Extensions.Logging;


namespace Complex742.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        { 
            _logger = logger;
        }

        public ViewResult Index()
        {
            _logger.LogInformation("HomeController called.Index");
            return View("~/Views/Home/Index.cshtml");
        }
        
    }
}