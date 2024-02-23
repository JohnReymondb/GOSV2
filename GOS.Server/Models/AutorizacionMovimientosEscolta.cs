using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class AutorizacionMovimientosEscolta
{
    public int IdAutorizacionMovimientosEscoltas { get; set; }

    public int IdAutorizacionMovimientos { get; set; }

    public string Rut { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public virtual AutorizacionMovimiento IdAutorizacionMovimientosNavigation { get; set; } = null!;
}
