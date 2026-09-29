using System.ComponentModel.DataAnnotations;

namespace H1Revisao01.Models
{
    public class Voto
    {
        [Required]
        public string RA { get; set; }

        [Required]
        public DateTime DataVoto { get; set; }

        [Required]
        public int NumeroCandidato { get; set; }
    }
}