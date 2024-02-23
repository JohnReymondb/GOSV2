using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class InspeccionVisualEstado
{
    public int IdInspeccionVisualEstado { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<InspeccionVisual> InspeccionVisuals { get; set; } = new List<InspeccionVisual>();
}
