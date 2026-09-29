using Microsoft.AspNetCore.Mvc;
using H1Revisao01.Models;
using H1Revisao01.Interfaces;

namespace H1Revisao01.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VotoController : ControllerBase
    {
        private readonly ICandidatoRepository repository;

        public VotoController(ICandidatoRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public IActionResult Registrar(Voto voto)
        {
            Candidato candidato =
                repository.BuscarPorNumero(voto.NumeroCandidato);

            if (candidato == null)
            {
                return BadRequest("O candidato informado não existe.");
            }

            if (voto.DataVoto == DateTime.MinValue)
            {
                voto.DataVoto = DateTime.Now;
            }

            repository.AdicionarVoto(voto);

            return Created("", voto);
        }

        [HttpGet("{numero}")]
        public IActionResult ConsultarVotos(int numero)
        {
            Candidato candidato =
                repository.BuscarPorNumero(numero);

            if (candidato == null)
            {
                return NotFound("Candidato não encontrado.");
            }

            List<Voto> votos =
                repository.ListarVotosPorCandidato(numero);

            return Ok(votos);
        }
    }
}