using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class PerfilesPermiso
{
    public int IdPerfilesPermisos { get; set; }

    public int IdPerfiles { get; set; }

    public int IdPerfilesAcciones { get; set; }

    public int IdMenus { get; set; }

    public int? IdSubMenus { get; set; }

    public bool Estado { get; set; }

    public virtual Perfile IdPerfilesNavigation { get; set; } = null!;

    public virtual Submenu? IdSubMenusNavigation { get; set; }
}
