using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class CorreosGlobale
{
    public int IdCorreosGlobales { get; set; }

    public string TextoHtml { get; set; } = null!;

    public string Titulo { get; set; } = null!;
}
