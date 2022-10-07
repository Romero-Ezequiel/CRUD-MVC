using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CRUD.Models
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<Personas> Personas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personas>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Personas>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Personas>()
                .Property(e => e.correo)
                .IsUnicode(false);
        }
    }
}
