using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp_DIO_Modulo_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CSharp_DIO_Modulo_API.Context
{
    public class AgendaContext:DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options):base(options)
        {
        }

        // Contato - Classe de entidade que será mapeada para a tabela
        public DbSet<Contato> Contatos { get; set; }
    }
}