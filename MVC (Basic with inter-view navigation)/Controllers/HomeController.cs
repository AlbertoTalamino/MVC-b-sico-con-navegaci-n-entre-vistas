using Microsoft.AspNetCore.Mvc;
using MVC__Basic_with_inter_view_navigation_.Models;
using System.Diagnostics;

namespace MVC__Basic_with_inter_view_navigation_.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View(ListUsers());
        }

        public static List<string> ListUsers()
        {
            List<string> ListUsers = new List<string>();
            ListUsers.Add("Fernando");
            ListUsers.Add("Alejandra");
            ListUsers.Add("Raul");
            ListUsers.Add("Martin");
            ListUsers.Add("Ernesto");
            return ListUsers;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}