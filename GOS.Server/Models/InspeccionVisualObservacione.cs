using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class InspeccionVisualObservacione
{
    public int IdInspeccionVisualObservaciones { get; set; }

    public int IdInspeccionVisual { get; set; }

    public DateTime Fecha { get; set; }

    public int IdUsuario { get; set; }

    public string Observacion { get; set; } = null!;

    public virtual InspeccionVisual IdInspeccionVisualNavigation { get; set; } = null!;
}
