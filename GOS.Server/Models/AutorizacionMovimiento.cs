using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class AutorizacionMovimiento
{
    public int IdAutorizacionMovimientos { get; set; }

    public int IdPersona { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int IdAutorizacionMovimientosEstado { get; set; }

    public int IdAutorizacionMovimientosTipo { get; set; }

    public int IdGerencia { get; set; }

    public int IdSuperIntendencia { get; set; }

    public int IdOperadorSolicitante { get; set; }

    public string OrigenCarga { get; set; } = null!;

    public string DestinoCarga { get; set; } = null!;

    public string DescripcionCargo { get; set; } = null!;

    public string Alto { get; set; } = null!;

    public string Largo { get; set; } = null!;

    public string Ancho { get; set; } = null!;

    public string Peso { get; set; } = null!;

    public int? IdEmpresaEmisoraGuiaFactura { get; set; }

    public string NroGuiaFactura { get; set; } = null!;

    public decimal ValorCarga { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public int HorasDuracion { get; set; }

    public string HoraInicio { get; set; } = null!;

    public string HoraFin { get; set; } = null!;

    public int IdEmpresaTransportista { get; set; }

    public int? IdEmpresaEscolta { get; set; }

    public string PpuTracto { get; set; } = null!;

    public string? PpuEquipo { get; set; }

    public bool Acreditado { get; set; }

    public string? PpuCamionetaEscolta { get; set; }

    public bool CamionetaAcreditada { get; set; }

    public bool ChoferConPase { get; set; }

    public bool InformeTecnicoValido { get; set; }

    public string? NroInformeTecnico { get; set; }

    public string? NroResolucion { get; set; }

    public bool EstudioRuta { get; set; }

    public bool CoordinacionCarabineros { get; set; }

    public bool VistoBuenoApp { get; set; }

    public bool RespaldoCorreo { get; set; }

    public string? GuiaDespacho { get; set; }

    public string? AutorizacionMlp { get; set; }

    public string? InformeTecnico { get; set; }

    public string? Resolucion { get; set; }

    public string? AnexoestudioRuta { get; set; }

    public string? Observacion { get; set; }

    public string? AnexoGuardia { get; set; }

    public string? ObservacionGuardia { get; set; }

    public virtual ICollection<AutorizacionMovimientosChofere> AutorizacionMovimientosChoferes { get; set; } = new List<AutorizacionMovimientosChofere>();

    public virtual ICollection<AutorizacionMovimientosEscolta> AutorizacionMovimientosEscolta { get; set; } = new List<AutorizacionMovimientosEscolta>();

    public virtual AutorizacionMovimientosEstado IdAutorizacionMovimientosEstadoNavigation { get; set; } = null!;

    public virtual AutorizacionMovimientosTipo IdAutorizacionMovimientosTipoNavigation { get; set; } = null!;

    public virtual Empresa? IdEmpresaEscoltaNavigation { get; set; }

    public virtual Empresa IdEmpresaTransportistaNavigation { get; set; } = null!;

    public virtual Gerencia IdGerenciaNavigation { get; set; } = null!;

    public virtual Persona IdOperadorSolicitanteNavigation { get; set; } = null!;

    public virtual Persona IdPersonaNavigation { get; set; } = null!;

    public virtual SuperIntendencia IdSuperIntendenciaNavigation { get; set; } = null!;
}
