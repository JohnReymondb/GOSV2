using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class DeclaracionEspeciesDetalle
{
    public int IdDeclaracionEspeciesDetalle { get; set; }

    public int IdDeclaracionEspecies { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public string NroSerie { get; set; } = null!;

    public virtual DeclaracionEspecy IdDeclaracionEspeciesNavigation { get; set; } = null!;
}
