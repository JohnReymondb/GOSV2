using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class DeclaracionEspecy
{
    public int IdDeclaracionEspecies { get; set; }

    public int IdEmpresas { get; set; }

    public int IdPersonas { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string ContratoOst { get; set; } = null!;

    public int IdLugarInspeccion { get; set; }

    public bool Validador { get; set; }

    public string? Pertenencia { get; set; }

    public virtual ICollection<DeclaracionEspeciesDetalle> DeclaracionEspeciesDetalles { get; set; } = new List<DeclaracionEspeciesDetalle>();

    public virtual Empresa IdEmpresasNavigation { get; set; } = null!;

    public virtual LugarInspeccion IdLugarInspeccionNavigation { get; set; } = null!;

    public virtual Persona IdPersonasNavigation { get; set; } = null!;
}
