using SistemaCadastroContatos.Data;
using SistemaCadastroContatos.Models;

namespace SistemaCadastroContatos.Repositories
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
       
    }
}
