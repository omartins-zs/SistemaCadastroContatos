using System.ComponentModel.DataAnnotations;

namespace SistemaCadastroContatos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite o login")]
        public string Senha { get; set; }
    }
}
