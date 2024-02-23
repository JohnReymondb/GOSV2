using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class TipoSolicitudHorasLugarExaman
{
    public int Id { get; set; }

    public int IdTipoSolicitudHoras { get; set; }

    public int IdThorasLugarExamen { get; set; }

    public virtual SolicitudHorasLugarExaman IdThorasLugarExamenNavigation { get; set; } = null!;

    public virtual SolicitudHorasTipoExaman IdTipoSolicitudHorasNavigation { get; set; } = null!;
}
