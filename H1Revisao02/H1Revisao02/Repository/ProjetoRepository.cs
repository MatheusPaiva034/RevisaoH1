using H1Revisao02.Interfaces;
using H1Revisao02.Models;

namespace H1Revisao02.Repository
{
    public class ProjetoRepository : IProjetoRepository
    {
        private static List<Projeto> projetos = new List<Projeto>();

        private static List<Visita> visitas = new List<Visita>();

        public void AdicionarProjeto(Projeto projeto)
        {
            projetos.Add(projeto);
        }

        public List<Projeto> ListarProjetos()
        {
            return projetos;
        }

        public Projeto BuscarPorNumero(int numero)
        {
            return projetos.FirstOrDefault(p => p.Numero == numero);
        }

        public void AdicionarVisita(Visita visita)
        {
            visitas.Add(visita);
        }

        public List<Visita> ListarVisitasPorProjeto(int numero)
        {
            return visitas
                .Where(v => v.NumeroProjeto == numero)
                .ToList();
        }
    }
}