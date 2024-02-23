using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class ControlesEmsObservacione
{
    public int IdControlesEmsObservaciones { get; set; }

    public int IdControlesEms { get; set; }

    public int IdControlesEmsCrInstalacion { get; set; }

    public DateTime Fecha { get; set; }

    public string Observacion { get; set; } = null!;

    public virtual ControlesEmsCrInstalacion IdControlesEmsCrInstalacionNavigation { get; set; } = null!;

    public virtual ControlesEm IdControlesEmsNavigation { get; set; } = null!;
}
