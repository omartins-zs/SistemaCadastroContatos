using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaCadastroContatos.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastroContatos.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();
            home.Nome = "Gabriel Martins";
            home.Email = "gabrielmartinsdev@gamil.com";

            return View(home);
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
