using H1Revisao02.Interfaces;
using H1Revisao02.Models;
using Microsoft.AspNetCore.Mvc;

namespace H1Revisao02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjetoController : ControllerBase
    {
        private readonly IProjetoRepository repository;

        public ProjetoController(IProjetoRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(Projeto projeto)
        {
            Projeto projetoExistente =
                repository.BuscarPorNumero(projeto.Numero);

            if (projetoExistente != null)
            {
                return BadRequest(
                    "Já existe um projeto com esse número."
                );
            }

            repository.AdicionarProjeto(projeto);

            return Created("", projeto);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(repository.ListarProjetos());
        }
    }
}