using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class ControlesEmsCrSentidoRutum
{
    public int IdControlesEmsCrSentidoRuta { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<ControlesEm> ControlesEms { get; set; } = new List<ControlesEm>();
}
