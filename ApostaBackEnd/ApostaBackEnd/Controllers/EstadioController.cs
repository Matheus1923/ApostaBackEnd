using ApostaBackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApostaBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadioController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public EstadioController (Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]
        public List<Estadio> Get()
        {
            return Contexto.Estadios.ToList();
        }

        // GET api/<EstadioController>/5
        [HttpGet("{id}")]
        public Estadio Get(int id)
        {
            return Contexto.Estadios.First(e => e.IdEstadio == id);
        }

        [HttpGet("idEstadio/{idEstadio}")]
        public List<Estadio> Filtrar(int id)
        {
            return Contexto.Estadios.Where(e => e.IdEstadio == id).ToList();
        }

        // PUT api/<EstadioController>/5
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Estadio>> Create(Estadio Estadio)
        {
            Estadio.IdEstadio = 0;
            Contexto.Estadios.Add(Estadio);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Estadio.IdEstadio, Estadio });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Estadio>> Update(Estadio Estadio)
        {
            Contexto.Estadios.Update(Estadio);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Estadio.IdEstadio, Estadio });
        }
    }
}
