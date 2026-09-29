
using Microsoft.AspNetCore.Mvc;
using H1Revisao01.Models;
using H1Revisao01.Interfaces;

namespace H1Revisao01.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class CandidatoController : ControllerBase
        {
            private readonly ICandidatoRepository repository;

            public CandidatoController(ICandidatoRepository repository)
            {
                this.repository = repository;
            }

            [HttpPost]
            public IActionResult Cadastrar(Candidato candidato)
            {
                Candidato candidatoExistente =
                    repository.BuscarPorNumero(candidato.Numero);

                if (candidatoExistente != null)
                {
                    return BadRequest("Já existe um candidato com esse número.");
                }

                repository.AdicionarCandidato(candidato);

                return Created("", candidato);
            }

            [HttpGet]
            public IActionResult Listar()
            {
                return Ok(repository.ListarCandidatos());
            }
        }
    }


