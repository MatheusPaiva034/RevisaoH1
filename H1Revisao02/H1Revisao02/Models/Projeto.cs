using System.ComponentModel.DataAnnotations;

namespace H1Revisao02.Models
{
    public class Projeto
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(1, 8)]
        public int Turma { get; set; }

        [Required]
        [StringLength(500)]
        public string Descricao { get; set; }

        [Required]
        [Range(10, 99)]
        public int Numero { get; set; }
    }
}