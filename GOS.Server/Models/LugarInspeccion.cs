using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class LugarInspeccion
{
    public int IdLugarInspeccion { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<DeclaracionEspecy> DeclaracionEspecies { get; set; } = new List<DeclaracionEspecy>();
}
