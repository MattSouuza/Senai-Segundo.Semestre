using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Interfaces;
using Senai.Peoples.WebApi.Repositories;

namespace Senai.Peoples.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private IFuncionarioRepository _funcionarioRepository { get; set; }

        public FuncionarioController()
        {
            _funcionarioRepository = new FuncionarioRepository();
        }

        /// <summary>
        /// Lista todos os funcionarios
        /// </summary>
        /// <returns>Retorna uma lista de funcionarios</returns>
        [HttpGet]
        public IEnumerable<FuncionariosDomain> Get()
        {
            return _funcionarioRepository.Listar();
        }

        /// <summary>
        /// Cadastra um novo funcionario
        /// </summary>
        /// <param name="funcionarioNovo">Objeto funcionarioNovo que será cadastrado</param>
        /// <returns>Retorna um BadRequest - 400, ou um Created - 201 se cadastrado com sucesso</returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public IActionResult Post(FuncionariosDomain funcionarioNovo)
        {
            _funcionarioRepository.Cadastrar(funcionarioNovo);

            if (funcionarioNovo.Nome == null)
            {
                return BadRequest("O nome do funcionario não foi informado, funcionario não cadastrado");
            }

            return StatusCode(201);
        }

        /// <summary>
        /// Busca um funcionario por nome e o lista
        /// </summary>
        /// <param name="nome">Objeto nome sera buscado no banco de dados</param>
        /// <returns>Retorna um BadRequest - 400, ou um Ok - 200 se o funcionario for encontrador</returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("buscarNome/{nome}")]
        public IActionResult GetPorNome(string nome)
        {
            FuncionariosDomain funcionarioBuscado = _funcionarioRepository.BuscarPorNome(nome);

            if (funcionarioBuscado == null)
            {
                return NotFound("Nenhum funcionario encontrado");
            }

            return Ok(funcionarioBuscado);
        }

        /// <summary>
        /// Lista todos os funcionarios, mostrando o nome completo deles em um só valor
        /// </summary>
        /// <returns>Retorna uma lista dos funcionarios</returns>
        [HttpGet("buscarNomeCompleto")]
        public IEnumerable<FuncionariosDomain> GetNomeCompleto()
        {
            return _funcionarioRepository.ListarNomeCompleto();
        }

        /// <summary>
        /// Busca 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetPorId(int id)
        {
            FuncionariosDomain funcionarioBuscado = _funcionarioRepository.BuscarPoId(id);

            if (funcionarioBuscado == null)
            {
                return NotFound("Nenhum funcionario encontrado");
            }

            return Ok(funcionarioBuscado);
        }

        [HttpPut("{id}")]
        public IActionResult PutPorId(int id, FuncionariosDomain funcionarioNovo)
        {
            FuncionariosDomain funcionarioBuscado = _funcionarioRepository.BuscarPoId(id);

            if (funcionarioBuscado != null)
            {
                _funcionarioRepository.Atualizar(id, funcionarioNovo);

                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _funcionarioRepository.Deletar(id);

            return Ok("Funcionario deletado");
        }

    }
}