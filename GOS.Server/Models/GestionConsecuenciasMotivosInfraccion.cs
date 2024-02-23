using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class GestionConsecuenciasMotivosInfraccion
{
    public int IdMotivoInfraccion { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<GestionConsecuenciasInfraccione> GestionConsecuenciasInfracciones { get; set; } = new List<GestionConsecuenciasInfraccione>();
}
