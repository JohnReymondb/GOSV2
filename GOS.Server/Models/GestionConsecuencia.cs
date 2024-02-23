using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class GestionConsecuencia
{
    public int IdGestionConsecuencias { get; set; }

    public int IdGestionConsecuenciasTipo { get; set; }

    public int IdGestionConsecuenciasEstado { get; set; }

    public int IdEmpresa { get; set; }

    public int IdPersona { get; set; }

    public string Patente { get; set; } = null!;

    public string LicenciaMunicipal { get; set; } = null!;

    public string SectorControl { get; set; } = null!;

    public string AreaTrabajo { get; set; } = null!;

    public DateTime FechaInfraccion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string? OtroMotivo { get; set; }

    public string? AnexoInfraccion { get; set; }

    public string? ComentarioInicioCumplimiento { get; set; }

    public string? ComentarioTerminoCumplimiento { get; set; }

    public string? NomBreUsuarioComentarioTerminoCumplimiento { get; set; }

    public DateTime FechaFinalizacionSancion { get; set; }

    public int? DiasAcumplir { get; set; }

    public virtual ICollection<GestionConsecuenciasInfraccione> GestionConsecuenciasInfracciones { get; set; } = new List<GestionConsecuenciasInfraccione>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual GestionConsecuenciasEstado IdGestionConsecuenciasEstadoNavigation { get; set; } = null!;

    public virtual GestionConsecuenciasTipo IdGestionConsecuenciasTipoNavigation { get; set; } = null!;

    public virtual Persona IdPersonaNavigation { get; set; } = null!;
}
