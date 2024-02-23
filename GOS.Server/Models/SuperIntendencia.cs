using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class SuperIntendencia
{
    public int IdSuperIntendencia { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<AutorizacionMovimiento> AutorizacionMovimientos { get; set; } = new List<AutorizacionMovimiento>();
}
