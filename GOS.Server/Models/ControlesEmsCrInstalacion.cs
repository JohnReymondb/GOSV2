using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class ControlesEmsCrInstalacion
{
    public int IdControlesEmsCrInstalacion { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<ControlesEm> ControlesEms { get; set; } = new List<ControlesEm>();

    public virtual ICollection<ControlesEmsObservacione> ControlesEmsObservaciones { get; set; } = new List<ControlesEmsObservacione>();
}
