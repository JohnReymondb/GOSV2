using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GOS.Server.Models;

public partial class GosContext : DbContext
{
    public GosContext()
    {
    }

    public GosContext(DbContextOptions<GosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AutorizacionMovimiento> AutorizacionMovimientos { get; set; }

    public virtual DbSet<AutorizacionMovimientoHistorial> AutorizacionMovimientoHistorials { get; set; }

    public virtual DbSet<AutorizacionMovimientosChofere> AutorizacionMovimientosChoferes { get; set; }

    public virtual DbSet<AutorizacionMovimientosEscolta> AutorizacionMovimientosEscoltas { get; set; }

    public virtual DbSet<AutorizacionMovimientosEstado> AutorizacionMovimientosEstados { get; set; }

    public virtual DbSet<AutorizacionMovimientosTipo> AutorizacionMovimientosTipos { get; set; }

    public virtual DbSet<ConfirguracionCorreo> ConfirguracionCorreos { get; set; }

    public virtual DbSet<ControlesEm> ControlesEms { get; set; }

    public virtual DbSet<ControlesEmsCfestado> ControlesEmsCfestados { get; set; }

    public virtual DbSet<ControlesEmsCfproyectoDestino> ControlesEmsCfproyectoDestinos { get; set; }

    public virtual DbSet<ControlesEmsCftipoRechazo> ControlesEmsCftipoRechazos { get; set; }

    public virtual DbSet<ControlesEmsCftipoSolicitud> ControlesEmsCftipoSolicituds { get; set; }

    public virtual DbSet<ControlesEmsCrInstalacion> ControlesEmsCrInstalacions { get; set; }

    public virtual DbSet<ControlesEmsCrLugarControl> ControlesEmsCrLugarControls { get; set; }

    public virtual DbSet<ControlesEmsCrSentidoRutum> ControlesEmsCrSentidoRuta { get; set; }

    public virtual DbSet<ControlesEmsCrTipoControlRutum> ControlesEmsCrTipoControlRuta { get; set; }

    public virtual DbSet<ControlesEmsHistorial> ControlesEmsHistorials { get; set; }

    public virtual DbSet<ControlesEmsObservacione> ControlesEmsObservaciones { get; set; }

    public virtual DbSet<ControlesEmsPersona> ControlesEmsPersonas { get; set; }

    public virtual DbSet<ControlesEmsTipo> ControlesEmsTipos { get; set; }

    public virtual DbSet<CorreosGlobale> CorreosGlobales { get; set; }

    public virtual DbSet<DeclaracionEspeciesDetalle> DeclaracionEspeciesDetalles { get; set; }

    public virtual DbSet<DeclaracionEspeciesHistorial> DeclaracionEspeciesHistorials { get; set; }

    public virtual DbSet<DeclaracionEspecy> DeclaracionEspecies { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Gerencia> Gerencias { get; set; }

    public virtual DbSet<GestionConsecuencia> GestionConsecuencias { get; set; }

    public virtual DbSet<GestionConsecuenciasEstado> GestionConsecuenciasEstados { get; set; }

    public virtual DbSet<GestionConsecuenciasHistorial> GestionConsecuenciasHistorials { get; set; }

    public virtual DbSet<GestionConsecuenciasInfraccione> GestionConsecuenciasInfracciones { get; set; }

    public virtual DbSet<GestionConsecuenciasMotivosInfraccion> GestionConsecuenciasMotivosInfraccions { get; set; }

    public virtual DbSet<GestionConsecuenciasTipo> GestionConsecuenciasTipos { get; set; }

    public virtual DbSet<HorasTipo> HorasTipos { get; set; }

    public virtual DbSet<InspeccionVisual> InspeccionVisuals { get; set; }

    public virtual DbSet<InspeccionVisualEstado> InspeccionVisualEstados { get; set; }

    public virtual DbSet<InspeccionVisualHistorial> InspeccionVisualHistorials { get; set; }

    public virtual DbSet<InspeccionVisualObservacione> InspeccionVisualObservaciones { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<LugarInspeccion> LugarInspeccions { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Perfile> Perfiles { get; set; }

    public virtual DbSet<PerfilesAccione> PerfilesAcciones { get; set; }

    public virtual DbSet<PerfilesPermiso> PerfilesPermisos { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<PersonasEstado> PersonasEstados { get; set; }

    public virtual DbSet<SolicitudExcepcione> SolicitudExcepciones { get; set; }

    public virtual DbSet<SolicitudExcepcionesEstado> SolicitudExcepcionesEstados { get; set; }

    public virtual DbSet<SolicitudExcepcionesHistorial> SolicitudExcepcionesHistorials { get; set; }

    public virtual DbSet<SolicitudExcepcionesTipo> SolicitudExcepcionesTipos { get; set; }

    public virtual DbSet<SolicitudHora> SolicitudHoras { get; set; }

    public virtual DbSet<SolicitudHorasHistorial> SolicitudHorasHistorials { get; set; }

    public virtual DbSet<SolicitudHorasLugarExaman> SolicitudHorasLugarExamen { get; set; }

    public virtual DbSet<SolicitudHorasMecanico> SolicitudHorasMecanicos { get; set; }

    public virtual DbSet<SolicitudHorasTipoExaman> SolicitudHorasTipoExamen { get; set; }

    public virtual DbSet<Submenu> Submenus { get; set; }

    public virtual DbSet<SuperIntendencia> SuperIntendencias { get; set; }

    public virtual DbSet<TipoSolicitudHorasLugarExaman> TipoSolicitudHorasLugarExamen { get; set; }

    public virtual DbSet<TipoVehiculo> TipoVehiculos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    public virtual DbSet<VehiculosEstado> VehiculosEstados { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AutorizacionMovimiento>(entity =>
        {
            entity.HasKey(e => e.IdAutorizacionMovimientos);

            entity.HasIndex(e => e.IdAutorizacionMovimientosEstado, "IX_AutorizacionMovimientos_IdAutorizacionMovimientosEstado");

            entity.HasIndex(e => e.IdAutorizacionMovimientosTipo, "IX_AutorizacionMovimientos_IdAutorizacionMovimientosTipo");

            entity.HasIndex(e => e.IdEmpresaEscolta, "IX_AutorizacionMovimientos_IdEmpresaEscolta");

            entity.HasIndex(e => e.IdEmpresaTransportista, "IX_AutorizacionMovimientos_IdEmpresaTransportista");

            entity.HasIndex(e => e.IdGerencia, "IX_AutorizacionMovimientos_IdGerencia");

            entity.HasIndex(e => e.IdOperadorSolicitante, "IX_AutorizacionMovimientos_IdOperadorSolicitante");

            entity.HasIndex(e => e.IdPersona, "IX_AutorizacionMovimientos_IdPersona");

            entity.HasIndex(e => e.IdSuperIntendencia, "IX_AutorizacionMovimientos_IdSuperIntendencia");

            entity.Property(e => e.Alto)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Ancho)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.AnexoGuardia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("anexoGuardia");
            entity.Property(e => e.AnexoestudioRuta)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("anexoestudioRuta");
            entity.Property(e => e.AutorizacionMlp)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCargo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DestinoCarga)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GuiaDespacho)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.HoraFin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoraInicio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InformeTecnico)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Largo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.NroGuiaFactura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NroInformeTecnico)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NroResolucion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observacion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionGuardia)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OrigenCarga)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Peso)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PpuCamionetaEscolta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PpuEquipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PpuTracto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Resolucion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("resolucion");
            entity.Property(e => e.ValorCarga).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.IdAutorizacionMovimientosEstadoNavigation).WithMany(p => p.AutorizacionMovimientos).HasForeignKey(d => d.IdAutorizacionMovimientosEstado);

            entity.HasOne(d => d.IdAutorizacionMovimientosTipoNavigation).WithMany(p => p.AutorizacionMovimientos).HasForeignKey(d => d.IdAutorizacionMovimientosTipo);

            entity.HasOne(d => d.IdEmpresaEscoltaNavigation).WithMany(p => p.AutorizacionMovimientoIdEmpresaEscoltaNavigations).HasForeignKey(d => d.IdEmpresaEscolta);

            entity.HasOne(d => d.IdEmpresaTransportistaNavigation).WithMany(p => p.AutorizacionMovimientoIdEmpresaTransportistaNavigations)
                .HasForeignKey(d => d.IdEmpresaTransportista)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdGerenciaNavigation).WithMany(p => p.AutorizacionMovimientos).HasForeignKey(d => d.IdGerencia);

            entity.HasOne(d => d.IdOperadorSolicitanteNavigation).WithMany(p => p.AutorizacionMovimientoIdOperadorSolicitanteNavigations)
                .HasForeignKey(d => d.IdOperadorSolicitante)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.AutorizacionMovimientoIdPersonaNavigations)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdSuperIntendenciaNavigation).WithMany(p => p.AutorizacionMovimientos).HasForeignKey(d => d.IdSuperIntendencia);
        });

        modelBuilder.Entity<AutorizacionMovimientoHistorial>(entity =>
        {
            entity.HasKey(e => e.IdautorizacionMovimientosHistorico);

            entity.ToTable("AutorizacionMovimientoHistorial");

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Persona)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("persona");
            entity.Property(e => e.Rut)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rut");
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<AutorizacionMovimientosChofere>(entity =>
        {
            entity.HasKey(e => e.IdAutorizacionMovimientosChoferes);

            entity.HasIndex(e => e.IdAutorizacionMovimientos, "IX_AutorizacionMovimientosChoferes_IdAutorizacionMovimientos");

            entity.HasOne(d => d.IdAutorizacionMovimientosNavigation).WithMany(p => p.AutorizacionMovimientosChoferes).HasForeignKey(d => d.IdAutorizacionMovimientos);
        });

        modelBuilder.Entity<AutorizacionMovimientosEscolta>(entity =>
        {
            entity.HasKey(e => e.IdAutorizacionMovimientosEscoltas);

            entity.HasIndex(e => e.IdAutorizacionMovimientos, "IX_AutorizacionMovimientosEscoltas_IdAutorizacionMovimientos");

            entity.HasOne(d => d.IdAutorizacionMovimientosNavigation).WithMany(p => p.AutorizacionMovimientosEscolta).HasForeignKey(d => d.IdAutorizacionMovimientos);
        });

        modelBuilder.Entity<AutorizacionMovimientosEstado>(entity =>
        {
            entity.HasKey(e => e.IdAutorizacionMovimientosEstado);

            entity.ToTable("AutorizacionMovimientosEstado");
        });

        modelBuilder.Entity<AutorizacionMovimientosTipo>(entity =>
        {
            entity.HasKey(e => e.IdAutorizacionMovimientosTipo);

            entity.ToTable("autorizacionMovimientosTipos");

            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConfirguracionCorreo>(entity =>
        {
            entity.ToTable("confirguracionCorreos");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Puerto).HasColumnName("puerto");
            entity.Property(e => e.Ssl).HasColumnName("ssl");
        });

        modelBuilder.Entity<ControlesEm>(entity =>
        {
            entity.HasKey(e => e.IdControlesEms);

            entity.HasIndex(e => e.IdControlesEmsTipo, "IX_ControlesEms_IdControlesEmsTipo");

            entity.HasIndex(e => e.IdEmpresa, "IX_ControlesEms_IdEmpresa");

            entity.HasIndex(e => e.IdInstalacion, "IX_ControlesEms_IdInstalacion");

            entity.HasIndex(e => e.IdLugarControl, "IX_ControlesEms_IdLugarControl");

            entity.HasIndex(e => e.IdSentidoRuta, "IX_ControlesEms_IdSentidoRuta");

            entity.HasIndex(e => e.IdUsuario, "IX_ControlesEms_IdUsuario");

            entity.HasIndex(e => e.IdtipoSolicitud, "IX_ControlesEms_IdtipoSolicitud");

            entity.HasIndex(e => e.Estado, "IX_ControlesEms_estado");

            entity.HasIndex(e => e.IdTipoVehiculo, "IX_ControlesEms_idTipoVehiculo");

            entity.Property(e => e.AnoVehiculo)
                .IsUnicode(false)
                .HasColumnName("anoVehiculo");
            entity.Property(e => e.Color)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Condicion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("condicion");
            entity.Property(e => e.EmpresaGps)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("empresaGps");
            entity.Property(e => e.EquiposUsados)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Fin)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Folio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("folio");
            entity.Property(e => e.IdTipoVehiculo).HasColumnName("idTipoVehiculo");
            entity.Property(e => e.InformacionRecomendacion).HasColumnName("informacionRecomendacion");
            entity.Property(e => e.Inicio)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Instalacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("instalacion");
            entity.Property(e => e.JefeTurno)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Marca).IsUnicode(false);
            entity.Property(e => e.Modelo).IsUnicode(false);
            entity.Property(e => e.NombreServicio)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Patente).IsUnicode(false);
            entity.Property(e => e.RegistroMantencion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VehiculoEnLugar)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.EstadoNavigation).WithMany(p => p.ControlesEms).HasForeignKey(d => d.Estado);

            entity.HasOne(d => d.Estado1).WithMany(p => p.ControlesEms).HasForeignKey(d => d.Estado);

            entity.HasOne(d => d.IdControlesEmsTipoNavigation).WithMany(p => p.ControlesEms).HasForeignKey(d => d.IdControlesEmsTipo);

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ControlesEms).HasForeignKey(d => d.IdEmpresa);

            entity.HasOne(d => d.IdInstalacionNavigation).WithMany(p => p.ControlesEms).HasForeignKey(d => d.IdInstalacion);

            entity.HasOne(d => d.IdLugarControlNavigation).WithMany(p => p.ControlesEms).HasForeignKey(d => d.IdLugarControl);

            entity.HasOne(d => d.IdSentidoRutaNavigation).WithMany(p => p.ControlesEms).HasForeignKey(d => d.IdSentidoRuta);

            entity.HasOne(d => d.IdTipoVehiculoNavigation).WithMany(p => p.ControlesEms).HasForeignKey(d => d.IdTipoVehiculo);

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.ControlesEms).HasForeignKey(d => d.IdUsuario);

            entity.HasOne(d => d.IdtipoSolicitudNavigation).WithMany(p => p.ControlesEms).HasForeignKey(d => d.IdtipoSolicitud);
        });

        modelBuilder.Entity<ControlesEmsCfestado>(entity =>
        {
            entity.HasKey(e => e.IdControlesEmsCfestados);

            entity.ToTable("ControlesEmsCFEstados");

            entity.Property(e => e.IdControlesEmsCfestados).HasColumnName("IdControlesEmsCFEstados");
        });

        modelBuilder.Entity<ControlesEmsCfproyectoDestino>(entity =>
        {
            entity.HasKey(e => e.IdControlesEmsCfproyectoDestino);

            entity.ToTable("ControlesEmsCFProyectoDestino");

            entity.Property(e => e.IdControlesEmsCfproyectoDestino).HasColumnName("IdControlesEmsCFProyectoDestino");
        });

        modelBuilder.Entity<ControlesEmsCftipoRechazo>(entity =>
        {
            entity.HasKey(e => e.IdControlesEmsCfTipoRechazo);

            entity.ToTable("ControlesEmsCFTipoRechazo");
        });

        modelBuilder.Entity<ControlesEmsCftipoSolicitud>(entity =>
        {
            entity.HasKey(e => e.IdControlesEmsCftipoSolicitud);

            entity.ToTable("ControlesEmsCFTipoSolicitud");

            entity.Property(e => e.IdControlesEmsCftipoSolicitud).HasColumnName("IdControlesEmsCFTipoSolicitud");
        });

        modelBuilder.Entity<ControlesEmsCrInstalacion>(entity =>
        {
            entity.HasKey(e => e.IdControlesEmsCrInstalacion);

            entity.ToTable("ControlesEmsCrInstalacion");
        });

        modelBuilder.Entity<ControlesEmsCrLugarControl>(entity =>
        {
            entity.HasKey(e => e.IdControlesEmsCrLugarControl);

            entity.ToTable("ControlesEmsCrLugarControl");
        });

        modelBuilder.Entity<ControlesEmsCrSentidoRutum>(entity =>
        {
            entity.HasKey(e => e.IdControlesEmsCrSentidoRuta);
        });

        modelBuilder.Entity<ControlesEmsCrTipoControlRutum>(entity =>
        {
            entity.HasKey(e => e.IdControlesEmsCrTipoControlRuta);
        });

        modelBuilder.Entity<ControlesEmsHistorial>(entity =>
        {
            entity.HasKey(e => e.IdControlesEmshistorial);

            entity.ToTable("ControlesEmsHistorial");

            entity.Property(e => e.Accion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ControlesEmsObservacione>(entity =>
        {
            entity.HasKey(e => e.IdControlesEmsObservaciones);

            entity.HasIndex(e => e.IdControlesEms, "IX_ControlesEmsObservaciones_IdControlesEms");

            entity.HasIndex(e => e.IdControlesEmsCrInstalacion, "IX_ControlesEmsObservaciones_IdControlesEmsCrInstalacion");

            entity.Property(e => e.Observacion)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.IdControlesEmsNavigation).WithMany(p => p.ControlesEmsObservaciones).HasForeignKey(d => d.IdControlesEms);

            entity.HasOne(d => d.IdControlesEmsCrInstalacionNavigation).WithMany(p => p.ControlesEmsObservaciones).HasForeignKey(d => d.IdControlesEmsCrInstalacion);
        });

        modelBuilder.Entity<ControlesEmsPersona>(entity =>
        {
            entity.HasKey(e => e.IdControlesEmsPersonas);

            entity.HasIndex(e => e.IdControlesEms, "IX_ControlesEmsPersonas_IdControlesEms");

            entity.HasIndex(e => e.IdPersona, "IX_ControlesEmsPersonas_IdPersona");

            entity.HasOne(d => d.IdControlesEmsNavigation).WithMany(p => p.ControlesEmsPersonas).HasForeignKey(d => d.IdControlesEms);

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.ControlesEmsPersonas)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ControlesEmsTipo>(entity =>
        {
            entity.HasKey(e => e.IdControlesTipo);

            entity.ToTable("ControlesEmsTipo");

            entity.Property(e => e.Nombre)
                .HasMaxLength(155)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CorreosGlobale>(entity =>
        {
            entity.HasKey(e => e.IdCorreosGlobales);

            entity.Property(e => e.TextoHtml).IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<DeclaracionEspeciesDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDeclaracionEspeciesDetalle);

            entity.ToTable("DeclaracionEspeciesDetalle");

            entity.HasIndex(e => e.IdDeclaracionEspecies, "IX_DeclaracionEspeciesDetalle_IdDeclaracionEspecies");

            entity.Property(e => e.IdDeclaracionEspeciesDetalle).HasColumnName("idDeclaracionEspeciesDetalle");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Marca)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.NroSerie)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.HasOne(d => d.IdDeclaracionEspeciesNavigation).WithMany(p => p.DeclaracionEspeciesDetalles).HasForeignKey(d => d.IdDeclaracionEspecies);
        });

        modelBuilder.Entity<DeclaracionEspeciesHistorial>(entity =>
        {
            entity.HasKey(e => e.IdDeclaracionEspeciesHistorial);

            entity.ToTable("DeclaracionEspeciesHistorial");

            entity.Property(e => e.Accion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DeclaracionEspecy>(entity =>
        {
            entity.HasKey(e => e.IdDeclaracionEspecies);

            entity.HasIndex(e => e.IdEmpresas, "IX_DeclaracionEspecies_IdEmpresas");

            entity.HasIndex(e => e.IdLugarInspeccion, "IX_DeclaracionEspecies_IdLugarInspeccion");

            entity.HasIndex(e => e.IdPersonas, "IX_DeclaracionEspecies_IdPersonas");

            entity.Property(e => e.ContratoOst)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Validador).HasColumnName("validador");

            entity.HasOne(d => d.IdEmpresasNavigation).WithMany(p => p.DeclaracionEspecies)
                .HasForeignKey(d => d.IdEmpresas)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdLugarInspeccionNavigation).WithMany(p => p.DeclaracionEspecies).HasForeignKey(d => d.IdLugarInspeccion);

            entity.HasOne(d => d.IdPersonasNavigation).WithMany(p => p.DeclaracionEspecies)
                .HasForeignKey(d => d.IdPersonas)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa);

            entity.Property(e => e.CorreoRepresentante).HasDefaultValue("");
            entity.Property(e => e.NombreRepresentante)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Rut)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Gerencia>(entity =>
        {
            entity.HasKey(e => e.IdGerencia);

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GestionConsecuencia>(entity =>
        {
            entity.HasKey(e => e.IdGestionConsecuencias);

            entity.HasIndex(e => e.IdGestionConsecuenciasEstado, "IX_GestionConsecuencias_IdGestionConsecuenciasEstado");

            entity.HasIndex(e => e.IdGestionConsecuenciasTipo, "IX_GestionConsecuencias_IdGestionConsecuenciasTipo");

            entity.HasIndex(e => e.IdEmpresa, "IX_GestionConsecuencias_idEmpresa");

            entity.HasIndex(e => e.IdPersona, "IX_GestionConsecuencias_idPersona");

            entity.Property(e => e.AnexoInfraccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AreaTrabajo)
                .HasMaxLength(155)
                .IsUnicode(false);
            entity.Property(e => e.ComentarioInicioCumplimiento)
                .HasMaxLength(155)
                .IsUnicode(false);
            entity.Property(e => e.ComentarioTerminoCumplimiento)
                .HasMaxLength(155)
                .IsUnicode(false);
            entity.Property(e => e.DiasAcumplir).HasColumnName("diasACumplir");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.IdPersona).HasColumnName("idPersona");
            entity.Property(e => e.LicenciaMunicipal)
                .HasMaxLength(55)
                .IsUnicode(false);
            entity.Property(e => e.OtroMotivo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("otroMotivo");
            entity.Property(e => e.SectorControl)
                .HasMaxLength(155)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.GestionConsecuencia)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdGestionConsecuenciasEstadoNavigation).WithMany(p => p.GestionConsecuencia).HasForeignKey(d => d.IdGestionConsecuenciasEstado);

            entity.HasOne(d => d.IdGestionConsecuenciasTipoNavigation).WithMany(p => p.GestionConsecuencia).HasForeignKey(d => d.IdGestionConsecuenciasTipo);

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.GestionConsecuencia)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<GestionConsecuenciasEstado>(entity =>
        {
            entity.HasKey(e => e.IdGestionConsecuenciasEstado);

            entity.ToTable("GestionConsecuenciasEstado");

            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GestionConsecuenciasHistorial>(entity =>
        {
            entity.HasKey(e => e.IdGestionConsecuenciasHistorial);

            entity.ToTable("GestionConsecuenciasHistorial");

            entity.Property(e => e.Accion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GestionConsecuenciasInfraccione>(entity =>
        {
            entity.HasKey(e => e.IdGestionConsecuenciasInfracciones);

            entity.HasIndex(e => e.IdGestionConsecuencias, "IX_GestionConsecuenciasInfracciones_IdGestionConsecuencias");

            entity.HasIndex(e => e.IdGestionConsecuenciasMotivoInfraccion, "IX_GestionConsecuenciasInfracciones_IdGestionConsecuenciasMotivoInfraccion");

            entity.HasOne(d => d.IdGestionConsecuenciasNavigation).WithMany(p => p.GestionConsecuenciasInfracciones).HasForeignKey(d => d.IdGestionConsecuencias);

            entity.HasOne(d => d.IdGestionConsecuenciasMotivoInfraccionNavigation).WithMany(p => p.GestionConsecuenciasInfracciones).HasForeignKey(d => d.IdGestionConsecuenciasMotivoInfraccion);
        });

        modelBuilder.Entity<GestionConsecuenciasMotivosInfraccion>(entity =>
        {
            entity.HasKey(e => e.IdMotivoInfraccion);

            entity.ToTable("GestionConsecuenciasMotivosInfraccion");

            entity.Property(e => e.Nombre)
                .HasMaxLength(450)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GestionConsecuenciasTipo>(entity =>
        {
            entity.HasKey(e => e.IdGestionConsecuenciasTipo);

            entity.ToTable("GestionConsecuenciasTipo");

            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HorasTipo>(entity =>
        {
            entity.HasKey(e => e.IdHorasTipo);
        });

        modelBuilder.Entity<InspeccionVisual>(entity =>
        {
            entity.HasKey(e => e.IdInspeccionVisual);

            entity.ToTable("InspeccionVisual");

            entity.HasIndex(e => e.IdEmpresa, "IX_InspeccionVisual_IdEmpresa");

            entity.HasIndex(e => e.IdInspeccionVisualEstado, "IX_InspeccionVisual_IdInspeccionVisualEstado");

            entity.HasIndex(e => e.IdPersonas, "IX_InspeccionVisual_IdPersonas");

            entity.HasIndex(e => e.IdSolicitudHoras, "IX_InspeccionVisual_IdSolicitudHoras")
                .IsUnique()
                .HasFilter("([IdSolicitudHoras] IS NOT NULL)");

            entity.HasIndex(e => e.IdTipoVehiculo, "IX_InspeccionVisual_IdTipoVehiculo");

            entity.HasIndex(e => e.IdUsuario, "IX_InspeccionVisual_IdUsuario");

            entity.Property(e => e.Ac).HasColumnName("AC");
            entity.Property(e => e.Amortiguadores).HasColumnName("amortiguadores");
            entity.Property(e => e.Anexo1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Anexo2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Anexo3)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Btorcion).HasColumnName("BTorcion");
            entity.Property(e => e.Color)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Marca)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ppu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PPU");
            entity.Property(e => e.Resortes).HasColumnName("resortes");
            entity.Property(e => e.Tipo)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.InspeccionVisuals).HasForeignKey(d => d.IdEmpresa);

            entity.HasOne(d => d.IdInspeccionVisualEstadoNavigation).WithMany(p => p.InspeccionVisuals).HasForeignKey(d => d.IdInspeccionVisualEstado);

            entity.HasOne(d => d.IdPersonasNavigation).WithMany(p => p.InspeccionVisuals)
                .HasForeignKey(d => d.IdPersonas)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdSolicitudHorasNavigation).WithOne(p => p.InspeccionVisual).HasForeignKey<InspeccionVisual>(d => d.IdSolicitudHoras);

            entity.HasOne(d => d.IdTipoVehiculoNavigation).WithMany(p => p.InspeccionVisuals).HasForeignKey(d => d.IdTipoVehiculo);

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.InspeccionVisuals)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<InspeccionVisualEstado>(entity =>
        {
            entity.HasKey(e => e.IdInspeccionVisualEstado);

            entity.ToTable("InspeccionVisualEstado");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InspeccionVisualHistorial>(entity =>
        {
            entity.HasKey(e => e.IdInspeccionVisualHistorial);

            entity.ToTable("InspeccionVisualHistorial");

            entity.Property(e => e.Accion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InspeccionVisualObservacione>(entity =>
        {
            entity.HasKey(e => e.IdInspeccionVisualObservaciones);

            entity.HasIndex(e => e.IdInspeccionVisual, "IX_InspeccionVisualObservaciones_IdInspeccionVisual");

            entity.HasOne(d => d.IdInspeccionVisualNavigation).WithMany(p => p.InspeccionVisualObservaciones).HasForeignKey(d => d.IdInspeccionVisual);
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.IdLogin);

            entity.ToTable("login");

            entity.Property(e => e.Accion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("accion");
            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<LugarInspeccion>(entity =>
        {
            entity.HasKey(e => e.IdLugarInspeccion);

            entity.ToTable("LugarInspeccion");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.IdMenu);

            entity.Property(e => e.Accion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("accion");
            entity.Property(e => e.Clase).HasColumnName("clase");
            entity.Property(e => e.Controler)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("controler");
            entity.Property(e => e.DataTarget)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Perfile>(entity =>
        {
            entity.HasKey(e => e.IdPerfiles);

            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PerfilesAccione>(entity =>
        {
            entity.HasKey(e => e.IdPerfilesAcciones);

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PerfilesPermiso>(entity =>
        {
            entity.HasKey(e => e.IdPerfilesPermisos);

            entity.HasIndex(e => e.IdPerfiles, "IX_PerfilesPermisos_IdPerfiles");

            entity.HasIndex(e => e.IdSubMenus, "IX_PerfilesPermisos_IdSubMenus");

            entity.Property(e => e.Estado).HasColumnName("estado");

            entity.HasOne(d => d.IdPerfilesNavigation).WithMany(p => p.PerfilesPermisos).HasForeignKey(d => d.IdPerfiles);

            entity.HasOne(d => d.IdSubMenusNavigation).WithMany(p => p.PerfilesPermisos).HasForeignKey(d => d.IdSubMenus);
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.IdPersonas);

            entity.HasIndex(e => e.IdEstadoPersona, "IX_Personas_IdEstadoPersona");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Rut)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tlf)
                .HasMaxLength(13)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEstadoPersonaNavigation).WithMany(p => p.Personas).HasForeignKey(d => d.IdEstadoPersona);
        });

        modelBuilder.Entity<PersonasEstado>(entity =>
        {
            entity.HasKey(e => e.IdPersonasEstado);
        });

        modelBuilder.Entity<SolicitudExcepcione>(entity =>
        {
            entity.HasKey(e => e.IdSolicitudExcepciones);

            entity.HasIndex(e => e.IdEmpresa, "IX_SolicitudExcepciones_IdEmpresa");

            entity.HasIndex(e => e.IdSolicitante, "IX_SolicitudExcepciones_IdSolicitante");

            entity.HasIndex(e => e.IdSolicitudExepcionesEstado, "IX_SolicitudExcepciones_IdSolicitudExepcionesEstado");

            entity.HasIndex(e => e.IdSolicitudExepcionesTipo, "IX_SolicitudExcepciones_IdSolicitudExepcionesTipo");

            entity.Property(e => e.IdSolicitudExcepciones).HasColumnName("idSolicitudExcepciones");
            entity.Property(e => e.Autorizacion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.GuiaAutorizada)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.MotivosPuntuales)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RespaldoMotivosPuntuales)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.SolicitudExcepciones)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdSolicitanteNavigation).WithMany(p => p.SolicitudExcepciones)
                .HasForeignKey(d => d.IdSolicitante)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdSolicitudExepcionesEstadoNavigation).WithMany(p => p.SolicitudExcepciones).HasForeignKey(d => d.IdSolicitudExepcionesEstado);

            entity.HasOne(d => d.IdSolicitudExepcionesTipoNavigation).WithMany(p => p.SolicitudExcepciones).HasForeignKey(d => d.IdSolicitudExepcionesTipo);
        });

        modelBuilder.Entity<SolicitudExcepcionesEstado>(entity =>
        {
            entity.HasKey(e => e.IdSolicitudExcepcionesEstado);

            entity.ToTable("SolicitudExcepcionesEstado");
        });

        modelBuilder.Entity<SolicitudExcepcionesHistorial>(entity =>
        {
            entity.HasKey(e => e.IdSolicitudExcepcionesHistorial);

            entity.ToTable("SolicitudExcepcionesHistorial");

            entity.Property(e => e.Accion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("accion");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SolicitudExcepcionesTipo>(entity =>
        {
            entity.HasKey(e => e.IdSolicitudExcepcionesTipo);

            entity.ToTable("SolicitudExcepcionesTipo");
        });

        modelBuilder.Entity<SolicitudHora>(entity =>
        {
            entity.HasKey(e => e.IdSolicitudHoras);

            entity.HasIndex(e => e.IdEmpresa, "IX_SolicitudHoras_IdEmpresa");

            entity.HasIndex(e => e.IdExamen, "IX_SolicitudHoras_IdExamen");

            entity.HasIndex(e => e.IdExaminador, "IX_SolicitudHoras_IdExaminador");

            entity.HasIndex(e => e.IdLugarExamen, "IX_SolicitudHoras_IdLugarExamen");

            entity.HasIndex(e => e.IdPersona, "IX_SolicitudHoras_IdPersona");

            entity.Property(e => e.Finalizado).HasColumnName("finalizado");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.SolicitudHoras)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdExamenNavigation).WithMany(p => p.SolicitudHoras).HasForeignKey(d => d.IdExamen);

            entity.HasOne(d => d.IdExaminadorNavigation).WithMany(p => p.SolicitudHoras).HasForeignKey(d => d.IdExaminador);

            entity.HasOne(d => d.IdLugarExamenNavigation).WithMany(p => p.SolicitudHoras).HasForeignKey(d => d.IdLugarExamen);

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.SolicitudHoras)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<SolicitudHorasHistorial>(entity =>
        {
            entity.HasKey(e => e.IdSolicitudHorasHistorial);

            entity.ToTable("SolicitudHorasHistorial");

            entity.Property(e => e.Accion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SolicitudHorasLugarExaman>(entity =>
        {
            entity.HasKey(e => e.IdSolicitudHorasLugarExamen);
        });

        modelBuilder.Entity<SolicitudHorasMecanico>(entity =>
        {
            entity.HasKey(e => e.IdMecanico);

            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Apellidos).HasColumnName("apellidos");
            entity.Property(e => e.NombreExterno).HasColumnName("nombreExterno");
            entity.Property(e => e.Rut).HasColumnName("rut");
        });

        modelBuilder.Entity<SolicitudHorasTipoExaman>(entity =>
        {
            entity.HasKey(e => e.IdSolicitudHoraTipoExamen);
        });

        modelBuilder.Entity<Submenu>(entity =>
        {
            entity.HasKey(e => e.IdSubMenu);

            entity.ToTable("Submenu");

            entity.HasIndex(e => e.IdMenu, "IX_Submenu_IdMenu");

            entity.Property(e => e.Accion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Color).HasColumnName("color");
            entity.Property(e => e.Controler)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).HasColumnName("descripcion");
            entity.Property(e => e.Icono).HasColumnName("icono");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TextoBoton).HasColumnName("textoBoton");
            entity.Property(e => e.Titulo).HasColumnName("titulo");
            entity.Property(e => e.Visible).HasColumnName("visible");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.Submenus).HasForeignKey(d => d.IdMenu);
        });

        modelBuilder.Entity<SuperIntendencia>(entity =>
        {
            entity.HasKey(e => e.IdSuperIntendencia);
        });

        modelBuilder.Entity<TipoSolicitudHorasLugarExaman>(entity =>
        {
            entity.ToTable("tipoSolicitudHorasLugarExamen");

            entity.HasIndex(e => e.IdThorasLugarExamen, "IX_tipoSolicitudHorasLugarExamen_idTHorasLugarExamen");

            entity.HasIndex(e => e.IdTipoSolicitudHoras, "IX_tipoSolicitudHorasLugarExamen_idTipoSolicitudHoras");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdThorasLugarExamen).HasColumnName("idTHorasLugarExamen");
            entity.Property(e => e.IdTipoSolicitudHoras).HasColumnName("idTipoSolicitudHoras");

            entity.HasOne(d => d.IdThorasLugarExamenNavigation).WithMany(p => p.TipoSolicitudHorasLugarExamen).HasForeignKey(d => d.IdThorasLugarExamen);

            entity.HasOne(d => d.IdTipoSolicitudHorasNavigation).WithMany(p => p.TipoSolicitudHorasLugarExamen)
                .HasForeignKey(d => d.IdTipoSolicitudHoras)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TipoVehiculo>(entity =>
        {
            entity.HasKey(e => e.IdTipoVehiculo);

            entity.ToTable("TipoVehiculo");

            entity.Property(e => e.IdTipoVehiculo).HasColumnName("idTipoVehiculo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario);

            entity.HasIndex(e => e.IdPerfil, "IX_Usuarios_IdPerfil");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Clave)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Rut)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Usuario1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Usuario");

            entity.HasOne(d => d.IdPerfilNavigation).WithMany(p => p.Usuarios).HasForeignKey(d => d.IdPerfil);
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.IdVehiculos);

            entity.HasIndex(e => e.IdVehiculosEstado, "IX_Vehiculos_IdVehiculosEstado");

            entity.HasOne(d => d.IdVehiculosEstadoNavigation).WithMany(p => p.Vehiculos).HasForeignKey(d => d.IdVehiculosEstado);
        });

        modelBuilder.Entity<VehiculosEstado>(entity =>
        {
            entity.HasKey(e => e.IdVehiculosEstado);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
