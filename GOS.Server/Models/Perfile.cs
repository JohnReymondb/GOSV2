using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class Perfile
{
    public int IdPerfiles { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<PerfilesPermiso> PerfilesPermisos { get; set; } = new List<PerfilesPermiso>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
