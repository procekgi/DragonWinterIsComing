using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DragonWinterIsComing.Models
{
  
        public class Context : DbContext
        {
            public Context(DbContextOptions<Context> options) : base(options) { }
            public DbSet<Pessoa> Pessoas { get; set; }
            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<Piloto> Pilotos { get; set; }
            public DbSet<Dragao> Dragoes { get; set; }
            public DbSet<Viagem> Viagens { get; set; }
            public DbSet<Categoria> Categorias { get; set; }

            
        }

       
    }

