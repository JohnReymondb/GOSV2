using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class GestionConsecuenciasInfraccione
{
    public int IdGestionConsecuenciasInfracciones { get; set; }

    public int IdGestionConsecuencias { get; set; }

    public int IdGestionConsecuenciasMotivoInfraccion { get; set; }

    public virtual GestionConsecuenciasMotivosInfraccion IdGestionConsecuenciasMotivoInfraccionNavigation { get; set; } = null!;

    public virtual GestionConsecuencia IdGestionConsecuenciasNavigation { get; set; } = null!;
}
