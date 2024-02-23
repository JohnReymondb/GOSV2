using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class SolicitudExcepcione
{
    public int IdSolicitudExcepciones { get; set; }

    public int IdSolicitante { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSolicitudExepcionesTipo { get; set; }

    public int IdSolicitudExepcionesEstado { get; set; }

    public string? MotivosPuntuales { get; set; }

    public string? RespaldoMotivosPuntuales { get; set; }

    public string? Autorizacion { get; set; }

    public string? GuiaAutorizada { get; set; }

    public string? Observacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Persona IdSolicitanteNavigation { get; set; } = null!;

    public virtual SolicitudExcepcionesEstado IdSolicitudExepcionesEstadoNavigation { get; set; } = null!;

    public virtual SolicitudExcepcionesTipo IdSolicitudExepcionesTipoNavigation { get; set; } = null!;
}
