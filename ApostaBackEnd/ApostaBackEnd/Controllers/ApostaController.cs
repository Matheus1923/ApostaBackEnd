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
    public class ApostaController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public ApostaController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]
        public List<Aposta> Get()
        {
            return Contexto.Apostas.ToList();
        }

        [HttpGet("{id}")]
        public Aposta Get(int id)
        {
            return Contexto.Apostas.First(e => e.IdAposta == id);
        }

        [HttpGet("idAposta/{idAposta}")]
        public List<Aposta> filtrar(int id)
        {
            return Contexto.Apostas.Where(e => e.IdAposta == id).ToList();
        }


        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Aposta>> Create(Aposta Aposta)
        {
            Aposta.IdAposta = 0;
            Contexto.Apostas.Add(Aposta);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Aposta.IdAposta, Aposta });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Aposta>> Update(Aposta Aposta)
        {
            Contexto.Apostas.Update(Aposta);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Aposta.IdAposta, Aposta });
        }

    }
}
