using Microsoft.AspNetCore.Mvc;

namespace SistemaCadastroContatos.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
