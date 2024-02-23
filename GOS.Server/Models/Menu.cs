using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class Menu
{
    public int IdMenu { get; set; }

    public string Nombre { get; set; } = null!;

    public string Controler { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public string Clase { get; set; } = null!;

    public string DataTarget { get; set; } = null!;

    public virtual ICollection<Submenu> Submenus { get; set; } = new List<Submenu>();
}
