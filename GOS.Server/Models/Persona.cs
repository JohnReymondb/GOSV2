using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class Persona
{
    public int IdPersonas { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Rut { get; set; } = null!;

    public string Tlf { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public int IdEstadoPersona { get; set; }

    public virtual ICollection<AutorizacionMovimiento> AutorizacionMovimientoIdOperadorSolicitanteNavigations { get; set; } = new List<AutorizacionMovimiento>();

    public virtual ICollection<AutorizacionMovimiento> AutorizacionMovimientoIdPersonaNavigations { get; set; } = new List<AutorizacionMovimiento>();

    public virtual ICollection<ControlesEmsPersona> ControlesEmsPersonas { get; set; } = new List<ControlesEmsPersona>();

    public virtual ICollection<DeclaracionEspecy> DeclaracionEspecies { get; set; } = new List<DeclaracionEspecy>();

    public virtual ICollection<GestionConsecuencia> GestionConsecuencia { get; set; } = new List<GestionConsecuencia>();

    public virtual PersonasEstado IdEstadoPersonaNavigation { get; set; } = null!;

    public virtual ICollection<InspeccionVisual> InspeccionVisuals { get; set; } = new List<InspeccionVisual>();

    public virtual ICollection<SolicitudExcepcione> SolicitudExcepciones { get; set; } = new List<SolicitudExcepcione>();

    public virtual ICollection<SolicitudHora> SolicitudHoras { get; set; } = new List<SolicitudHora>();
}
