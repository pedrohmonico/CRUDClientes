using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDClientes.Models.Entidades;

namespace CRUDClientes.Models.Contexto
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> option) : base(option)
        {
            Database.EnsureCreated();
        }

        public DbSet<Clientes> Clientes { get; set; }
    }
}
