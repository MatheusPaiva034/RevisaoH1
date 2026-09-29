using H1Revisao01.Models;

namespace H1Revisao01.Interfaces
{
    public class CandidatoRepository : ICandidatoRepository
    {
        private static List<Candidato> candidatos = new List<Candidato>();

        private static List<Voto> votos = new List<Voto>();

        public void AdicionarCandidato(Candidato candidato)
        {
            candidatos.Add(candidato);
        }

        public List<Candidato> ListarCandidatos()
        {
            return candidatos;
        }

        public Candidato BuscarPorNumero(int numero)
        {
            return candidatos.FirstOrDefault(c => c.Numero == numero);
        }

        public void AdicionarVoto(Voto voto)
        {
            votos.Add(voto);
        }

        public List<Voto> ListarVotosPorCandidato(int numero)
        {
            return votos
                .Where(v => v.NumeroCandidato == numero)
                .ToList();
        }
    }
}