using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using videostreaming3.Models;

namespace videostreaming3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SurgeonsS1()
        {
            return View();
        }

        public IActionResult SurgeonsS2()
        {
            return View();
        }

        public IActionResult SurgeonsS3()
        {
            return View();
        }

        public IActionResult Lolita1997()
        {
            return View();
        }
        public IActionResult Doraemon()
        {
            return View();
        }

        public IActionResult Aladdin()
        {
            return View();
        }

        public IActionResult Lupin()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
