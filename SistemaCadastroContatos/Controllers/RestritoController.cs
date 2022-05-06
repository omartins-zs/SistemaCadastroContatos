using Microsoft.AspNetCore.Mvc;
using SistemaCadastroContatos.Filters;

namespace SistemaCadastroContatos.Controllers
{
    [PageUsuarioLogado]
    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
