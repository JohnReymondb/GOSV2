using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class InspeccionVisualHistorial
{
    public int IdInspeccionVisualHistorial { get; set; }

    public int IdInspeccionVisual { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string Accion { get; set; } = null!;
}
