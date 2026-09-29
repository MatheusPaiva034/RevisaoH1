
using H1Revisao01.Models;

namespace H1Revisao01.Interfaces
{
    public interface ICandidatoRepository
    {
        void AdicionarCandidato(Candidato candidato);

        List<Candidato> ListarCandidatos();

        Candidato BuscarPorNumero(int numero);

        void AdicionarVoto(Voto voto);

        List<Voto> ListarVotosPorCandidato(int numero);
    }
}