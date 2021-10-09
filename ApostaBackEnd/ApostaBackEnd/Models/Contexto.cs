using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApostaBackEnd.Models
{
    public class Contexto:DbContext
    {
        public DbSet<Aposta> Apostas { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Clube> Clubes { get; set; }

        public DbSet<Estadio> Estadios { get; set; }

        public DbSet<Jogo> Jogos { get; set; }

        public DbSet<Resultado> Resultados { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
    }
}
