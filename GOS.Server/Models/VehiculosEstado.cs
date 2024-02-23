using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class VehiculosEstado
{
    public int IdVehiculosEstado { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();
}
