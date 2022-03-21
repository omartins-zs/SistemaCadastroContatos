using SistemaCadastroContatos.Models;

namespace SistemaCadastroContatos.Repositories
{
    public interface IContatoRepository
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}
