using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.Modelos;

namespace Datos.Contexto
{
    public class D_ContextoBD : DbContext
    {
        public D_ContextoBD(DbContextOptions<D_ContextoBD> options) : base(options)
        {

        }

        public DbSet<E_Carrera> Carreras { get; set; }
        public DbSet<E_Materia> Materias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configuraciones adicionales
            
            //carreras
            modelBuilder.Entity<E_Carrera>().HasIndex(c=>c.ClaveCarrera).IsUnique();
            modelBuilder.Entity<E_Carrera>().HasIndex(c => c.NombreCarrera).IsUnique();

        }

    }
}
