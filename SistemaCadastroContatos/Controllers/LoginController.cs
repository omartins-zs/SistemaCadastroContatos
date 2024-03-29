﻿using Microsoft.AspNetCore.Http;
using SistemaCadastroContatos.Helper;
using Microsoft.AspNetCore.Mvc;
using SistemaCadastroContatos.Models;
using SistemaCadastroContatos.Repositories;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SistemaCadastroContatos.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        private readonly ISessao _sessao;

        private readonly IEmail _email;


        public LoginController(IUsuarioRepository usuarioRepository,
                               ISessao sessao,
                               IEmail email)
        {
            _usuarioRepository = usuarioRepository;
            _sessao = sessao;
            _email = email;
        }

        public IActionResult Index()
        {
            // Se o usuario ja estiver logado direcionar para a HOME
            if (_sessao.BuscarSessionDoUsuario() != null) return RedirectToAction("Index", "Home");

            return View();
        }

        public IActionResult RedefinirSenha()
        {

            return View();
        }

        public IActionResult Sair()
        {
            _sessao.RemoverSessionDoUsuario();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    UsuarioModel usuario = _usuarioRepository.BuscarPorLogin(loginModel.Login);

                    if (usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.Senha))
                        {                    
                            _sessao.CriarSessionDoUsuario(usuario);
                            return RedirectToAction("Index", "Home");
                        }

                        TempData["MensagemErro"] = $"Senha do usuário é inválida, tente novamente.";
                    }

                    TempData["MensagemErro"] = $"Usuário e/ou senha inválido(s). Por favor, tente novamente.";
                }
                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login, tente novamante, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult EnviarLinkParaRedefinirSenha(RedefinirSenhaModel redefinirSenhaModel)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    UsuarioModel usuario = _usuarioRepository.BuscarPorEmailELogin(redefinirSenhaModel.Email, redefinirSenhaModel.Login);

                    if (usuario != null)
                    {
                        string novaSenha = usuario.GerarNovaSenha();
                        string mensagem = $"Sua nova senha é: {novaSenha}";

                        bool emailEnviado = _email.Enviar(usuario.Email, "Sistema de Contatos - Nova Senha", mensagem);
                        
                        if (emailEnviado)
                        {
                            _usuarioRepository.Atualizar(usuario);
                            TempData["MensagemSucesso"] = $"Enviamos para seu E-mail cadastrado uma nova senha.";
                        }
                        else
                        {
                            TempData["MensagemErro"] = $"Nao conseguimos enviar o email. Por favor, tente novamente.";
                        }

                        return RedirectToAction("Index", "Login");
                    }

                    TempData["MensagemErro"] = $"Nao conseguimos redefinir sua senha. Por favor, verifique os dados informados.";
                }
                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos redefinir a sua senha, tente novamante, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}