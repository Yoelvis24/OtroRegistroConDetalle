using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CrearRegistroConDetalle.Entidades;

namespace CrearRegistroConDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<RolesDetalle> RolesDetalle { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GestionUsuarios.Db");
        }

    }
}
