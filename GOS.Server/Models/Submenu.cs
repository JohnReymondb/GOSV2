using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class Submenu
{
    public int IdSubMenu { get; set; }

    public string Nombre { get; set; } = null!;

    public string Controler { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public string Clase { get; set; } = null!;

    public int IdMenu { get; set; }

    public bool Visible { get; set; }

    public string? Icono { get; set; }

    public string? Color { get; set; }

    public string? Titulo { get; set; }

    public string? Descripcion { get; set; }

    public string? TextoBoton { get; set; }

    public virtual Menu IdMenuNavigation { get; set; } = null!;

    public virtual ICollection<PerfilesPermiso> PerfilesPermisos { get; set; } = new List<PerfilesPermiso>();
}
