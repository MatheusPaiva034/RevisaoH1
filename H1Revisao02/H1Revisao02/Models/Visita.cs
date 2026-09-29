
using System.ComponentModel.DataAnnotations;

namespace H1Revisao02.Models
{
    public class Visita
    {
        [Required]
        public string RA { get; set; }

        [Required]
        public DateTime DataVisita { get; set; }

        [Required]
        public int NumeroProjeto { get; set; }

        [Required]
        [Range(0, 5)]
        public double Nota { get; set; }
    }
}