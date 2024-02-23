using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class SolicitudHorasLugarExaman
{
    public int IdSolicitudHorasLugarExamen { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<SolicitudHora> SolicitudHoras { get; set; } = new List<SolicitudHora>();

    public virtual ICollection<TipoSolicitudHorasLugarExaman> TipoSolicitudHorasLugarExamen { get; set; } = new List<TipoSolicitudHorasLugarExaman>();
}
