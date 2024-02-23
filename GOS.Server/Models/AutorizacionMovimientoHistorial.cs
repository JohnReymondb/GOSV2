using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class AutorizacionMovimientoHistorial
{
    public int IdautorizacionMovimientosHistorico { get; set; }

    public int IdAutorizacionMovimientos { get; set; }

    public string Estado { get; set; } = null!;

    public string Rut { get; set; } = null!;

    public string Persona { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public DateTime FechaActualizacion { get; set; }
}
