using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Rut { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public int IdPerfil { get; set; }

    public string Usuario1 { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public virtual ICollection<ControlesEm> ControlesEms { get; set; } = new List<ControlesEm>();

    public virtual Perfile IdPerfilNavigation { get; set; } = null!;

    public virtual ICollection<InspeccionVisual> InspeccionVisuals { get; set; } = new List<InspeccionVisual>();
}
