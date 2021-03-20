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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permisos>().HasData(
                new Permisos() { PermisoId = 1, Nombre = "Alto", Descripcion = "Acceso completo", VecesAsignado = 0 },
                new Permisos() { PermisoId = 2, Nombre = "Medio", Descripcion = "Acceso a algunas funciones", VecesAsignado = 0 },
                new Permisos() { PermisoId = 3, Nombre = "Ninguno", Descripcion = "Sin acceso", VecesAsignado = 0 }
            );

            modelBuilder.Entity<Usuarios>().HasData(
                new Usuarios() { UsuarioId = 1, Alias = "Admin", Nombres = "Administrador", 
                                FechaIngreso = DateTime.Now, Activo = true, RolId = 1, 
                                Email = "admin@gmail.com", Clave = "12345"}
                );
        }
    }
}
