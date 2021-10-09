using ApostaBackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApostaBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubeController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public ClubeController (Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }
        [HttpGet]
        public List<Clube> Get()
        {
            return Contexto.Clubes.ToList();
        }

        // GET api/<ClubeController>/5
        [HttpGet("{id}")]
        public Clube Get(int id)
        {
            return Contexto.Clubes.First(e => e.IdClube == id);
        }

        [HttpGet("idclube/{idclube}")]
        public List<Clube> Filtrar(int id)
        {
            return Contexto.Clubes.Where(e => e.IdClube == id).ToList();
        }

        // PUT api/<ClubeController>/5
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Clube>> Create(Clube Clube)
        {
            Clube.IdClube = 0;
            Contexto.Clubes.Add(Clube);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Clube.IdClube, Clube });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Clube>> Update(Clube Clube)
        {
            Contexto.Clubes.Update(Clube);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Clube.IdClube, Clube });
        }
    }
}
