using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class SolicitudExcepcionesTipo
{
    public int IdSolicitudExcepcionesTipo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<SolicitudExcepcione> SolicitudExcepciones { get; set; } = new List<SolicitudExcepcione>();
}
