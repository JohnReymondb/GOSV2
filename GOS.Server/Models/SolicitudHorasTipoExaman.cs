using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class SolicitudHorasTipoExaman
{
    public int IdSolicitudHoraTipoExamen { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<SolicitudHora> SolicitudHoras { get; set; } = new List<SolicitudHora>();

    public virtual ICollection<TipoSolicitudHorasLugarExaman> TipoSolicitudHorasLugarExamen { get; set; } = new List<TipoSolicitudHorasLugarExaman>();
}
