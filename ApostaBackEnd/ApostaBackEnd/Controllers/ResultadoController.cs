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
    public class ResultadoController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public ResultadoController (Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]
        public List<Resultado> Get()
        {
            return Contexto.Resultados.ToList();
        }

        // GET api/<ResultadoController>/5
        [HttpGet("{id}")]
        public Resultado Get(int id)
        {
            return Contexto.Resultados.First(e => e.IdResultado == id);
        }

        [HttpGet("idResultado/{idResultado}")]
        public List<Resultado> Filtrar(int id)
        {
            return Contexto.Resultados.Where(e => e.IdResultado == id).ToList();
        }

        // PUT api/<ResultadoController>/5
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Resultado>> Create(Resultado Resultado)
        {
            Resultado.IdResultado = 0;
            Contexto.Resultados.Add(Resultado);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Resultado.IdResultado, Resultado });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Resultado>> Update(Resultado Resultado)
        {
            Contexto.Resultados.Update(Resultado);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Resultado.IdResultado, Resultado });
        }
    }
}
