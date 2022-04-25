using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SistemaCadastroContatos.Models;
using System.Threading.Tasks;

namespace SistemaCadastroContatos.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string sessaoUsuario = HttpContext.Session.GetString("sessionUsuarioLogado");

            if (string.IsNullOrEmpty(sessaoUsuario)) return null;

            UsuarioModel usuario = JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);

            return View(usuario);
        }
    }
}