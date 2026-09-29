using H1Revisao02.Interfaces;
using H1Revisao02.Models;
using Microsoft.AspNetCore.Mvc;

namespace H1Revisao02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VisitaController : ControllerBase
    {
        private readonly IProjetoRepository repository;

        public VisitaController(IProjetoRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public IActionResult Registrar(Visita visita)
        {
            Projeto projeto =
                repository.BuscarPorNumero(visita.NumeroProjeto);

            if (projeto == null)
            {
                return BadRequest(
                    "O projeto informado não existe."
                );
            }

            if (visita.DataVisita == DateTime.MinValue)
            {
                visita.DataVisita = DateTime.Now;
            }

            repository.AdicionarVisita(visita);

            return Created("", visita);
        }

        [HttpGet("{numero}")]
        public IActionResult Consultar(int numero)
        {
            Projeto projeto =
                repository.BuscarPorNumero(numero);

            if (projeto == null)
            {
                return NotFound(
                    "Projeto não encontrado."
                );
            }

            List<Visita> visitas =
                repository.ListarVisitasPorProjeto(numero);

            return Ok(visitas);
        }
    }
}