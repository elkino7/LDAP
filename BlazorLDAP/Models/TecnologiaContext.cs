using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BlazorLDAP.Models
{
    public partial class TecnologiaContext : DbContext
    {
        public TecnologiaContext()
        {
        }

        public TecnologiaContext(DbContextOptions<TecnologiaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Asignacion> Asignaciones { get; set; }
        public virtual DbSet<Compania> Companias { get; set; }
        public virtual DbSet<Equipo> Equipos { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Rol> Roles { get; set; }
        public virtual DbSet<Sucursal> Sucursales { get; set; }
        public virtual DbSet<TiposAsignacion> TiposAsignacions { get; set; }
        public virtual DbSet<TiposEquipo> TiposEquipos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SRVQACOL;Database=Tecnologia; User=elkin.ortiz; Password=Paulasofia7");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Asignacion>(entity =>
            {
                entity.HasKey(e => e.IdAsignacion)
                    .HasName("PK__Asignaci__A7235DFF89361A6A");

                entity.Property(e => e.DescripcionAsignacion)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAsignación).HasColumnType("date");

                entity.Property(e => e.NumeroActivoFijoAsignaciones)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCompaniaAsignacionesNavigation)
                    .WithMany(p => p.Asignaciones)
                    .HasForeignKey(d => d.IdCompaniaAsignaciones)
                    .HasConstraintName("FK__Asignacio__IdCom__76969D2E");

                entity.HasOne(d => d.IdTipoAsignacionAsignacionesNavigation)
                    .WithMany(p => p.Asignaciones)
                    .HasForeignKey(d => d.IdTipoAsignacionAsignaciones)
                    .HasConstraintName("FK__Asignacio__IdTip__73BA3083");

                entity.HasOne(d => d.NumeroActivoFijoAsignacionesNavigation)
                    .WithMany(p => p.Asignaciones)
                    .HasForeignKey(d => d.NumeroActivoFijoAsignaciones)
                    .HasConstraintName("FK__Asignacio__Numer__75A278F5");

                entity.HasOne(d => d.NumeroCedulaAsignacionesNavigation)
                    .WithMany(p => p.Asignaciones)
                    .HasForeignKey(d => d.NumeroCedulaAsignaciones)
                    .HasConstraintName("FK__Asignacio__Numer__74AE54BC");
            });

            modelBuilder.Entity<Compania>(entity =>
            {
                entity.HasKey(e => e.IdCompania)
                    .HasName("PK__Compania__12C8F033DBC863E6");

                entity.Property(e => e.NombreCompania)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstadoCompaniaNavigation)
                    .WithMany(p => p.Compania)
                    .HasForeignKey(d => d.IdEstadoCompania)
                    .HasConstraintName("FK__Companias__IdEst__3F466844");
            });

            modelBuilder.Entity<Equipo>(entity =>
            {
                entity.HasKey(e => e.NumeroActivoFijo)
                    .HasName("PK__Equipos__94557770C2EB6406");

                entity.Property(e => e.NumeroActivoFijo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFabricacionEquipo).HasColumnType("date");

                entity.Property(e => e.MarcaEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModeloEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerialEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.EstadoEquiposNavigation)
                    .WithMany(p => p.Equipos)
                    .HasForeignKey(d => d.EstadoEquipos)
                    .HasConstraintName("FK__Equipos__EstadoE__6FE99F9F");

                entity.HasOne(d => d.IdTipoEquipoEquiposNavigation)
                    .WithMany(p => p.Equipos)
                    .HasForeignKey(d => d.IdTipoEquipoEquipos)
                    .HasConstraintName("FK__Equipos__IdTipoE__70DDC3D8");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PK__Estados__FBB0EDC15359949A");

                entity.Property(e => e.DescripcionEstado)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__Roles__2A49584CBB78728B");

                entity.Property(e => e.DescripcionRol)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreRol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstadoRolNavigation)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.IdEstadoRol)
                    .HasConstraintName("FK__Roles__IdEstadoR__44FF419A");
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                entity.HasKey(e => e.IdSucursal)
                    .HasName("PK__Sucursal__BFB6CD99BE237883");

                entity.Property(e => e.IdSucursal)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadLocal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionSucursal)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NombreLocal)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstadoSucursalNavigation)
                    .WithMany(p => p.Sucursales)
                    .HasForeignKey(d => d.IdEstadoSucursal)
                    .HasConstraintName("FK__Sucursale__IdEst__4222D4EF");
            });

            modelBuilder.Entity<TiposAsignacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoAsignacion)
                    .HasName("PK__TiposAsi__D3DA5B94CC73BFF6");

                entity.ToTable("TiposAsignacion");

                entity.Property(e => e.DescricionAsignacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstadoTiposAsignacionNavigation)
                    .WithMany(p => p.TiposAsignacions)
                    .HasForeignKey(d => d.IdEstadoTiposAsignacion)
                    .HasConstraintName("FK__TiposAsig__IdEst__4CA06362");
            });

            modelBuilder.Entity<TiposEquipo>(entity =>
            {
                entity.HasKey(e => e.IdTipoEquipo)
                    .HasName("PK__TiposEqu__B62FEC67DE22015E");

                entity.ToTable("TiposEquipo");

                entity.Property(e => e.DescripcionEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.EstadoTipoEquipoNavigation)
                    .WithMany(p => p.TiposEquipos)
                    .HasForeignKey(d => d.EstadoTipoEquipo)
                    .HasConstraintName("FK__TiposEqui__Estad__38996AB5");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.NumeroCedula)
                    .HasName("PK__Usuarios__D4748AA84956FBD5");

                entity.Property(e => e.NumeroCedula).ValueGeneratedNever();

                entity.Property(e => e.ApellidoUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CargoUsuario)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.IdSucursalUsuario)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCentroUsuario)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstadoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdEstadoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuarios__IdEsta__619B8048");

                entity.HasOne(d => d.IdRolUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdRolUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuarios__IdRolU__5FB337D6");

                entity.HasOne(d => d.IdSucursalUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdSucursalUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuarios__IdSucu__60A75C0F");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
