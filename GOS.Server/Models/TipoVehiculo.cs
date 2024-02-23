using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class TipoVehiculo
{
    public int IdTipoVehiculo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<ControlesEm> ControlesEms { get; set; } = new List<ControlesEm>();

    public virtual ICollection<InspeccionVisual> InspeccionVisuals { get; set; } = new List<InspeccionVisual>();
}
