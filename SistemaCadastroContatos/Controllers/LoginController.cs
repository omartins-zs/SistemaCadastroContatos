using Microsoft.AspNetCore.Mvc;

namespace SistemaCadastroContatos.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
