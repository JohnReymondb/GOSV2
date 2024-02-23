using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class DeclaracionEspeciesHistorial
{
    public int IdDeclaracionEspeciesHistorial { get; set; }

    public int IdDeclaracionEspecies { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string Accion { get; set; } = null!;
}
