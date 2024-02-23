using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class SolicitudHorasMecanico
{
    public int IdMecanico { get; set; }

    public string NombreExterno { get; set; } = null!;

    public string Rut { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public bool Activo { get; set; }

    public virtual ICollection<SolicitudHora> SolicitudHoras { get; set; } = new List<SolicitudHora>();
}
