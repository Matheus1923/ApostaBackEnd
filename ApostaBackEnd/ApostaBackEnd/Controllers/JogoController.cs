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
    public class JogoController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public JogoController (Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]
        public List<Jogo> Get()
        {
            return Contexto.Jogos.ToList();
        }

        // GET api/<JogoController>/5
        [HttpGet("{id}")]
        public Jogo Get(int id)
        {
            return Contexto.Jogos.First(e => e.IdJogo == id);
        }

        [HttpGet("idJogo/{idJogo}")]
        public List<Jogo> Filtrar(int id)
        {
            return Contexto.Jogos.Where(e => e.IdJogo == id).ToList();
        }

        // PUT api/<JogoController>/5
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Jogo>> Create(Jogo Jogo)
        {
            Jogo.IdJogo = 0;
            Contexto.Jogos.Add(Jogo);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Jogo.IdJogo, Jogo });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Jogo>> Update(Jogo Jogo)
        {
            Contexto.Jogos.Update(Jogo);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Jogo.IdJogo, Jogo });
        }

    }
}
