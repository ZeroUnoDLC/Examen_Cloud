using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppMusica.Entidades;

    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext (DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<AppMusica.Entidades.Tipo_instrumento> Tipo_instrumentos { get; set; } = default!;

        public DbSet<AppMusica.Entidades.Instrumento_musical> Instrumentos_musicales { get; set; } = default!;
    }
