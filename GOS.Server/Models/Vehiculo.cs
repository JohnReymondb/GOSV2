using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class Vehiculo
{
    public int IdVehiculos { get; set; }

    public string Patente { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public int IdVehiculosEstado { get; set; }

    public virtual VehiculosEstado IdVehiculosEstadoNavigation { get; set; } = null!;
}
