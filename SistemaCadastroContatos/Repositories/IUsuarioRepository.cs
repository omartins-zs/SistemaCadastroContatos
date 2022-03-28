using SistemaCadastroContatos.Models;
using System.Collections.Generic;

namespace SistemaCadastroContatos.Repositories
{
    public interface IUsuarioRepository
    {
        List<UsuarioModel> BuscarTodos();
        UsuarioModel ListarPorId(int id);
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Apagar(int id);
    }
}
