using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class GestionConsecuenciasHistorial
{
    public int IdGestionConsecuenciasHistorial { get; set; }

    public int IdGestionConsecuencias { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string Accion { get; set; } = null!;
}
