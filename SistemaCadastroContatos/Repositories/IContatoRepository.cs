using SistemaCadastroContatos.Models;
using System.Collections.Generic;

namespace SistemaCadastroContatos.Repositories
{
    public interface IContatoRepository
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
