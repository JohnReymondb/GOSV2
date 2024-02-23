using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class InspeccionVisual
{
    public int IdInspeccionVisual { get; set; }

    public int? IdSolicitudHoras { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int IdTipoVehiculo { get; set; }

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public string Ppu { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public DateTime RevisionTecnica { get; set; }

    public DateTime PermisoCirculacion { get; set; }

    public int Kilometraje { get; set; }

    public string? Tipo { get; set; }

    public int Ano { get; set; }

    public string Color { get; set; } = null!;

    public bool Filtraciones { get; set; }

    public bool Autotronica { get; set; }

    public bool Ac { get; set; }

    public bool Humo { get; set; }

    public bool Auxiliar { get; set; }

    public bool Pedal { get; set; }

    public bool Motor { get; set; }

    public bool Aire { get; set; }

    public bool Amortiguadores { get; set; }

    public bool Resortes { get; set; }

    public bool Btorcion { get; set; }

    public bool Bujes { get; set; }

    public bool Terminales { get; set; }

    public bool CajaDirecciones { get; set; }

    public bool Barras { get; set; }

    public bool Fuerlles { get; set; }

    public bool IndTorques { get; set; }

    public bool RadioBase { get; set; }

    public bool Alarma { get; set; }

    public bool Certificados { get; set; }

    public string ColorSello { get; set; } = null!;

    public bool Func4x4 { get; set; }

    public bool Embriague { get; set; }

    public bool Automatica { get; set; }

    public bool Delanteras { get; set; }

    public bool Traseras { get; set; }

    public bool Pertiga { get; set; }

    public bool Baliza { get; set; }

    public bool Faenero { get; set; }

    public bool Interior { get; set; }

    public bool Exterior { get; set; }

    public bool JaulaInterna { get; set; }

    public string ServicioTecnico { get; set; } = null!;

    public bool Delanteros { get; set; }

    public bool Traseros { get; set; }

    public string? Anexo1 { get; set; }

    public string? Anexo2 { get; set; }

    public string? Anexo3 { get; set; }

    public int IdInspeccionVisualEstado { get; set; }

    public int IdPersonas { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual InspeccionVisualEstado IdInspeccionVisualEstadoNavigation { get; set; } = null!;

    public virtual Persona IdPersonasNavigation { get; set; } = null!;

    public virtual SolicitudHora? IdSolicitudHorasNavigation { get; set; }

    public virtual TipoVehiculo IdTipoVehiculoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<InspeccionVisualObservacione> InspeccionVisualObservaciones { get; set; } = new List<InspeccionVisualObservacione>();
}
