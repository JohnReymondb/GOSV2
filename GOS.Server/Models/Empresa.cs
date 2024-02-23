using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class Empresa
{
    public int IdEmpresa { get; set; }

    public string RazonSocial { get; set; } = null!;

    public string Rut { get; set; } = null!;

    public string NombreRepresentante { get; set; } = null!;

    public string CorreoRepresentante { get; set; } = null!;

    public virtual ICollection<AutorizacionMovimiento> AutorizacionMovimientoIdEmpresaEscoltaNavigations { get; set; } = new List<AutorizacionMovimiento>();

    public virtual ICollection<AutorizacionMovimiento> AutorizacionMovimientoIdEmpresaTransportistaNavigations { get; set; } = new List<AutorizacionMovimiento>();

    public virtual ICollection<ControlesEm> ControlesEms { get; set; } = new List<ControlesEm>();

    public virtual ICollection<DeclaracionEspecy> DeclaracionEspecies { get; set; } = new List<DeclaracionEspecy>();

    public virtual ICollection<GestionConsecuencia> GestionConsecuencia { get; set; } = new List<GestionConsecuencia>();

    public virtual ICollection<InspeccionVisual> InspeccionVisuals { get; set; } = new List<InspeccionVisual>();

    public virtual ICollection<SolicitudExcepcione> SolicitudExcepciones { get; set; } = new List<SolicitudExcepcione>();

    public virtual ICollection<SolicitudHora> SolicitudHoras { get; set; } = new List<SolicitudHora>();
}
