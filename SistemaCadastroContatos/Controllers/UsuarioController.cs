using Microsoft.AspNetCore.Mvc;
using SistemaCadastroContatos.Repositories;

namespace SistemaCadastroContatos.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
