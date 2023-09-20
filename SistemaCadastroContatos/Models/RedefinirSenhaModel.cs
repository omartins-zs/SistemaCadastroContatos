﻿using System.ComponentModel.DataAnnotations;

namespace SistemaCadastroContatos.Models
{
    public class RedefinirSenhaModel
    {
        [Required(ErrorMessage = "Digite o login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite o email")]
        public string Email { get; set; }
    }
}