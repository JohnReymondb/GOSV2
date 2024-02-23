using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class AutorizacionMovimientosTipo
{
    public int IdAutorizacionMovimientosTipo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<AutorizacionMovimiento> AutorizacionMovimientos { get; set; } = new List<AutorizacionMovimiento>();
}
