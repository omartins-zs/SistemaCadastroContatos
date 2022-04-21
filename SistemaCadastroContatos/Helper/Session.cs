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
            throw new System.NotImplementedException();
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
