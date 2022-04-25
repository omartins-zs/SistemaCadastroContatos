using SistemaCadastroContatos.Models;

namespace SistemaCadastroContatos.Helper
{
    public interface ISessao
    {
        void CriarSessionDoUsuario(UsuarioModel usuario);

        void RemoverSessionDoUsuario();
        UsuarioModel BuscarSessionDoUsuario();
    }
}
