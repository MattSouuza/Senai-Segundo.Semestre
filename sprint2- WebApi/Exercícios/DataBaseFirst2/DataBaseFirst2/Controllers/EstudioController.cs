using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataBaseFirst2.Domains;
using DataBaseFirst2.Interfaces;
using DataBaseFirst2.Repositories;

namespace DataBaseFirst2.Controllers
{
    [Produces("application/json")]
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

        [HttpPut("{id}")]
        public IActionResult Put(int id, Estudios estudioAtualizado)
        {
            Estudios estudioBuscado = _estudioRepository.BuscarPorId(id);

            if (estudioBuscado == null)
            {
                return NotFound("Estudio não encontrado");
            }

            _estudioRepository.Atualizar(id, estudioAtualizado);

            return Ok("Estudio atualizado");
        }
    }
}