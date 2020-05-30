using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.WebApi.DataBaseFirst.Domains;
using Senai.WebApi.DataBaseFirst.Interfaces;
using Senai.WebApi.DataBaseFirst.Repositories;

namespace Senai.WebApi.DataBaseFirst.Controllers
{
    [Produces("applicantion/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EstudioController : ControllerBase
    {
        private IEstudioRepository _estudioRepository;

        public EstudioController()
        {
            _estudioRepository = new EstudioRepository();
        }

        [HttpGet]
        public IEnumerable<Estudios> Get()
        {
            return _estudioRepository.Listar();
        }

        [HttpPut]
        public IActionResult Put(Estudios estudioAtualizado)
        {
            Estudios estudioBuscado = _estudioRepository.BuscarPorId(estudioAtualizado.IdEstudio);

            if (estudioBuscado == null)
            {
                return NotFound("Estudio não encontrado");
            }

            _estudioRepository.Atualizar(estudioAtualizado);

            return Ok("Estudio atualizado");
        }
    }
}