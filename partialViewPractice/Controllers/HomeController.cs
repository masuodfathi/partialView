using Microsoft.AspNetCore.Mvc;
using partialViewPractice.Models;
using System.Diagnostics;

namespace partialViewPractice.Controllers
{
    public class HomeController : Controller
    {
        private static Book Book { get; set; }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            Book = new Book()
            {
                id = 1,
                title = "Title",
                description = "Description",
            };
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(Book);
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