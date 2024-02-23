using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class SolicitudHora
{
    public int IdSolicitudHoras { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public int? IdExamen { get; set; }

    public int? IdLugarExamen { get; set; }

    public int? IdExaminador { get; set; }

    public int IdPersona { get; set; }

    public bool Finalizado { get; set; }

    public string? Observacion { get; set; }

    public int IdEmpresa { get; set; }

    public string? ComentarioSolicitante { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual SolicitudHorasTipoExaman? IdExamenNavigation { get; set; }

    public virtual SolicitudHorasMecanico? IdExaminadorNavigation { get; set; }

    public virtual SolicitudHorasLugarExaman? IdLugarExamenNavigation { get; set; }

    public virtual Persona IdPersonaNavigation { get; set; } = null!;

    public virtual InspeccionVisual? InspeccionVisual { get; set; }
}
