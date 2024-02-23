using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class GestionConsecuenciasTipo
{
    public int IdGestionConsecuenciasTipo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<GestionConsecuencia> GestionConsecuencia { get; set; } = new List<GestionConsecuencia>();
}
