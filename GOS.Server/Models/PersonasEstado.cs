using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class PersonasEstado
{
    public int IdPersonasEstado { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
