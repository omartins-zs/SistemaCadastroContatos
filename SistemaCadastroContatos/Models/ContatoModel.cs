using System.ComponentModel.DataAnnotations;

namespace SistemaCadastroContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Celular { get; set; }
    }
}
