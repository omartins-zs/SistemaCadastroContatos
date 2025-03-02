﻿using SistemaCadastroContatos.Models;
using System.Collections.Generic;

namespace SistemaCadastroContatos.Repositories
{
    public interface IUsuarioRepository
    {
          UsuarioModel BuscarPorLogin(string login);
        UsuarioModel BuscarPorEmailELogin(string email, string login);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel BuscarPorID(int id);
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);
        UsuarioModel AlterarSenha(AlterarSenhaModel alterarSenhaModel);
        bool Apagar (int id);
    }
}
