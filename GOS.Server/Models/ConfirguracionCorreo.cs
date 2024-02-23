using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class ConfirguracionCorreo
{
    public int Id { get; set; }

    public string Correo { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public string Smtp { get; set; } = null!;

    public int Puerto { get; set; }

    public bool Ssl { get; set; }
}
