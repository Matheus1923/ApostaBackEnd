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

        public DbSet<Cliente> clientes { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
    }
}
