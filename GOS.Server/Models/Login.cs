using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class Login
{
    public int IdLogin { get; set; }

    public string Usuario { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Accion { get; set; } = null!;
}
