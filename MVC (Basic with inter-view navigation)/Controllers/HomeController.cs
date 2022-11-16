using Microsoft.AspNetCore.Mvc;
using MVC__Basic_with_inter_view_navigation_.Models;
using System.Diagnostics;

namespace MVC__Basic_with_inter_view_navigation_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public object Session { get; private set; }

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
            return View();
        }

        public ActionResult ListaUsuarios()
        {
            List<string> listaUsuarios = new List<string>();
            listaUsuarios.Add("Fernando");
            listaUsuarios.Add("Alejandra");
            listaUsuarios.Add("Raul");
            listaUsuarios.Add("Martin");
            listaUsuarios.Add("Ernesto");

            //ViewBag.ListaUsuarios = listaUsuarios;
            //TempData["ListaUsuarios"] = listaUsuarios;
            Session["ListaUsuarios"] = listaUsuarios;
            //ViewData["ListaUsuarios"] = listaUsuarios;

            return View(listaUsuarios);
        }

        [HttpPost]
        public ActionResult ListaUsuarios(string selUsuarios)
        {
            ViewBag.Nombre = selUsuarios;
            //List<string> listaUsuarios = ViewBag.ListaUsuarios;
            //List<string> listaUsuarios = (List<string>)TempData["ListaUsuarios"];
            List<string> listaUsuarios = (List<string>)Session["ListaUsuarios"];
            //List<string> listaUsuarios = (List<string>)ViewData["ListaUsuarios"];
            return View(listaUsuarios);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}