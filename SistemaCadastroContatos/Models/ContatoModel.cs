using System.ComponentModel.DataAnnotations;

namespace SistemaCadastroContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do contato")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o e-mail do contato")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o celular do contato")]
        public string Celular { get; set; }
    }
}
