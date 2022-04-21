using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using SistemaCadastroContatos.Models;

namespace SistemaCadastroContatos.Helper
{
    public class Session : ISession
    {
        private readonly IHttpContextAccessor _httpContext;

        public Session(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }
        public UsuarioModel BuscarSessionDoUsuario()
        {
            string sessionUsuario = _httpContext.HttpContext.Session.GetString("sessionUsuarioLogado");

            if (string.IsNullOrEmpty(sessionUsuario)) return null;

            return JsonConvert.DeserializeObject<UsuarioModel>(sessionUsuario);
        }

        public void CriarSessionDoUsuario(UsuarioModel usuario)
        {
            string valor = JsonConvert.SerializeObject(usuario);
            _httpContext.HttpContext.Session.SetString("sessionUsuarioLogado", valor) ;
        }

        public void RemoverSessionDoUsuario()
        {
            throw new System.NotImplementedException();
        }
    }
}
