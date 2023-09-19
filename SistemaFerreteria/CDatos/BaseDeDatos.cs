using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CDatos
{
    public partial class FerreteriaEntities : DbContext
    {
        public FerreteriaEntities()
            : base("name=FerreteriaEntities")
        {
        }

        public virtual DbSet<Administrador> Administradors { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<ElementoDeSujecion> ElementoDeSujecions { get; set; }
        public virtual DbSet<Empleado> Empleadoes { get; set; }
        public virtual DbSet<EquipoDeSeguridad> EquipoDeSeguridads { get; set; }
        public virtual DbSet<Herramienta> Herramientas { get; set; }
        public virtual DbSet<HerramientaElectrica> HerramientaElectricas { get; set; }
        public virtual DbSet<HerramientaManual> HerramientaManuals { get; set; }
        public virtual DbSet<MaterialDeConstruccion> MaterialDeConstruccions { get; set; }
        public virtual DbSet<Producto> Productoes { get; set; }
        public virtual DbSet<Proveedor> Proveedors { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrador>()
                .Property(e => e.Dni)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Dni)
                .IsUnicode(false);

            modelBuilder.Entity<ElementoDeSujecion>()
                .Property(e => e.TipoElemento)
                .IsUnicode(false);

            modelBuilder.Entity<ElementoDeSujecion>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Dni)
                .IsUnicode(false);

            modelBuilder.Entity<EquipoDeSeguridad>()
                .Property(e => e.Talle)
                .IsUnicode(false);

            modelBuilder.Entity<EquipoDeSeguridad>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<EquipoDeSeguridad>()
                .Property(e => e.TipoEquipo)
                .IsUnicode(false);

            modelBuilder.Entity<EquipoDeSeguridad>()
                .Property(e => e.Normativa)
                .IsUnicode(false);

            modelBuilder.Entity<Herramienta>()
                .Property(e => e.Modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Herramienta>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Herramienta>()
                .HasMany(e => e.HerramientaElectricas)
                .WithOptional(e => e.Herramienta)
                .HasForeignKey(e => new { e.Modelo, e.Codigo });

            modelBuilder.Entity<Herramienta>()
                .HasMany(e => e.HerramientaManuals)
                .WithRequired(e => e.Herramienta)
                .HasForeignKey(e => new { e.Modelo, e.Codigo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HerramientaElectrica>()
                .Property(e => e.Potencia)
                .IsUnicode(false);

            modelBuilder.Entity<HerramientaElectrica>()
                .Property(e => e.Modelo)
                .IsUnicode(false);

            modelBuilder.Entity<HerramientaElectrica>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<HerramientaManual>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<HerramientaManual>()
                .Property(e => e.Modelo)
                .IsUnicode(false);

            modelBuilder.Entity<HerramientaManual>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<MaterialDeConstruccion>()
                .Property(e => e.Marca)
                .IsUnicode(false);

            modelBuilder.Entity<MaterialDeConstruccion>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<MaterialDeConstruccion>()
                .Property(e => e.Medidas)
                .IsUnicode(false);

            modelBuilder.Entity<MaterialDeConstruccion>()
                .Property(e => e.TipoMaterial)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.ElementoDeSujecions)
                .WithRequired(e => e.Producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.EquipoDeSeguridads)
                .WithRequired(e => e.Producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.Herramientas)
                .WithRequired(e => e.Producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.MaterialDeConstruccions)
                .WithRequired(e => e.Producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Dni)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Administradors)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Clientes)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Empleadoes)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);
        }
    }
}
