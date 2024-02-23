using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class SolicitudHorasHistorial
{
    public int IdSolicitudHorasHistorial { get; set; }

    public int IdSolicitudHoras { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string Accion { get; set; } = null!;
}
