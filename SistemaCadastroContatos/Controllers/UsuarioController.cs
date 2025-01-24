using Microsoft.AspNetCore.Mvc;
using SistemaCadastroContatos.Filters;
using SistemaCadastroContatos.Models;
using SistemaCadastroContatos.Repositories;
using System.Collections.Generic;

namespace SistemaCadastroContatos.Controllers
{
    [PageRestritaAdmin]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public IActionResult Index()
        {
            List<UsuarioModel> usuarios = _usuarioRepository.BuscarTodos();
            return View(usuarios);
        }

        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            UsuarioModel usuario = _usuarioRepository.BuscarPorID(id);
            return View(usuario);
        }
        public IActionResult Editar(int id)
        {
            UsuarioModel usuario = _usuarioRepository.BuscarPorID(id);
            return View(usuario);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _usuarioRepository.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Usuario excluido com sucesso";

                }
                else
                {
                    TempData["MensagemErro"] = $"Ops, nao conseguimos apagar seu usuario";
                }
                return RedirectToAction("Index");

            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, nao conseguimos apagar seu usuario, mais detalhe do erro: {erro.Message} ";

                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _usuarioRepository.Adicionar(usuario);
                    TempData["MensagemSucesso"] = "Usuario cadastrado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(usuario);
            }
            catch (System.Exception erro)
            {
                // ' $ ' para poder concatenar na mensagem
                TempData["MensagemErro"] = $"Ops, nao conseguimos cadastrar seu usuario, tente novamente, detalhe do erro: {erro.Message} ";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Editar(UsuarioSemSenhaModel usuarioSemSenhaModel)
        {
            try
            {
                UsuarioModel usuario = null;
                if (ModelState.IsValid)
                {
                    usuario = new UsuarioModel()
                    {
                        Id = usuarioSemSenhaModel.Id,
                        Nome = usuarioSemSenhaModel.Nome,
                        Login = usuarioSemSenhaModel.Login,
                        Email = usuarioSemSenhaModel.Email,
                        Perfil = usuarioSemSenhaModel.Perfil
                    };

                    usuario = _usuarioRepository.Atualizar(usuario);
                    TempData["MensagemSucesso"] = "Usuario alterado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(usuario);
            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Ops, nao conseguimos atualizar seu usuario, tente novamente, detalhe do erro: {erro.Message} ";
                return RedirectToAction("Index");
            }
        }
    }
}