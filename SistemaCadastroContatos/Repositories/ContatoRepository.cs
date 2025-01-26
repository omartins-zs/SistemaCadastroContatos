using SistemaCadastroContatos.Data;
using SistemaCadastroContatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaCadastroContatos.Repositories
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ContatoModel BuscarPorID(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> BuscarTodos(int usuarioId)
        {
            return _bancoContext.Contatos.Where(x => x.UsuarioId == usuarioId).ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = BuscarPorID(contato.Id);

            if (contatoDB == null) throw new Exception("Houve um erro na atualização do contato!");

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;

            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();

            return contatoDB;
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = BuscarPorID(id);

            if (contatoDB == null) throw new Exception("Houve um erro na deleção do contato!");

            _bancoContext.Contatos.Remove(contatoDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}