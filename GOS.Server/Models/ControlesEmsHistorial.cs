using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class ControlesEmsHistorial
{
    public int IdControlesEmshistorial { get; set; }

    public int IdControlesEms { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string Accion { get; set; } = null!;
}
