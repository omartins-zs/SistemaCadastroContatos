using Microsoft.AspNetCore.Mvc;

namespace SistemaCadastroContatos.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
