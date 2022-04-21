using SistemaCadastroContatos.Models;

namespace SistemaCadastroContatos.Helper
{
    public interface ISession
    {
        void CriarSessionDoUsuario(UsuarioModel usuario);

        void RemoverSessionDoUsuario();
        UsuarioModel BuscarSessionDoUsuario();
    }
}
