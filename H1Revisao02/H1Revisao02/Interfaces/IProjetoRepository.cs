using H1Revisao02.Models;

namespace H1Revisao02.Interfaces
{
    public interface IProjetoRepository
    {
        void AdicionarProjeto(Projeto projeto);

        List<Projeto> ListarProjetos();

        Projeto BuscarPorNumero(int numero);

        void AdicionarVisita(Visita visita);

        List<Visita> ListarVisitasPorProjeto(int numero);
    }
}