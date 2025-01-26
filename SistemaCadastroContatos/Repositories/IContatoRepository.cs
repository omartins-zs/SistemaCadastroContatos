using SistemaCadastroContatos.Models;
using System.Collections.Generic;

namespace SistemaCadastroContatos.Repositories
{
    public interface IContatoRepository
    {
        List<ContatoModel> BuscarTodos(int usuarioId);
        ContatoModel BuscarPorID(int id);
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }

}
