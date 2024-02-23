using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class ControlesEmsPersona
{
    public int IdControlesEmsPersonas { get; set; }

    public int IdControlesEms { get; set; }

    public int IdPersona { get; set; }

    public virtual ControlesEm IdControlesEmsNavigation { get; set; } = null!;

    public virtual Persona IdPersonaNavigation { get; set; } = null!;
}
