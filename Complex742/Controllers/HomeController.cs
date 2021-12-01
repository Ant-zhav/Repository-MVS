using Microsoft.AspNetCore.Mvc;


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
            _logger.LogInformation("HomeController.Index called");
            return View("~/Views/Home/Index.cshtml");
        }
    }
}