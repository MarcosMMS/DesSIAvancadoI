using System.ComponentModel.DataAnnotations;

namespace aula16_Razor.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }

        [Range(0, 120, ErrorMessage = "Idade inválida")]
        public int Idade { get; set; }
        
        [Required(ErrorMessage = "Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }
    }
}
