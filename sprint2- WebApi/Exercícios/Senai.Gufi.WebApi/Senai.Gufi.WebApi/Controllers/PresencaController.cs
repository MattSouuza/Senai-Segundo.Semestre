using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Gufi.WebApi.Domains;
using Senai.Gufi.WebApi.Interfaces;
using Senai.Gufi.WebApi.Repositories;

namespace Senai.Gufi.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PresencaController : ControllerBase
    {
        IPresencaRepository _presencaRepository;
        IUsuarioRepository _usuarioRepository;
        IEventoRepository _eventoRepository;

        public PresencaController()
        {
            _presencaRepository = new PresencaRepository();
        }

        [HttpPost]
        public IActionResult Convidar(Presenca convite)
        {

        }
    }
}