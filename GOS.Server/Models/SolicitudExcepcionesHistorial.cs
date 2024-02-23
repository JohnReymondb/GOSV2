using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class SolicitudExcepcionesHistorial
{
    public int IdSolicitudExcepcionesHistorial { get; set; }

    public int IdSolicitudExcepciones { get; set; }

    public string Usuario { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public DateTime Fecha { get; set; }
}
