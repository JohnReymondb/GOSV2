using System;
using System.Collections.Generic;

namespace GOS.Server.Models;

public partial class ControlesEm
{
    public int IdControlesEms { get; set; }

    public int IdControlesEmsTipo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int IdUsuario { get; set; }

    public string? Inicio { get; set; }

    public string? Fin { get; set; }

    public string? EquiposUsados { get; set; }

    public string? VehiculoEnLugar { get; set; }

    public string? Condicion { get; set; }

    public int? NarcoTest { get; set; }

    public int? AlcohoTest { get; set; }

    public string? RegistroEvidencia { get; set; }

    public string? ActaResultadoTest { get; set; }

    public string? ConsentimientoTest { get; set; }

    public string? Folio { get; set; }

    public string? Instalacion { get; set; }

    public int? IdTipoVehiculo { get; set; }

    public string? AnoVehiculo { get; set; }

    public string? Patente { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public int? Kilometraje { get; set; }

    public string? Color { get; set; }

    public int? Estado { get; set; }

    public int? TipoRechazo { get; set; }

    public int? IdEmpresa { get; set; }

    public string? EmpresaGps { get; set; }

    public string? RegistroMantencion { get; set; }

    public bool? BitacoraMantencion { get; set; }

    public bool? ServicioTecnico { get; set; }

    public bool? InformacionRecomendacion { get; set; }

    public string? NombreServicio { get; set; }

    public int? IdtipoSolicitud { get; set; }

    public int? IdPersona { get; set; }

    public int? IdSentidoRuta { get; set; }

    public int? VelMax { get; set; }

    public int? VelControl { get; set; }

    public int? DifVel { get; set; }

    public int? IdLugarControl { get; set; }

    public bool? Infraccion { get; set; }

    public string? JefeTurno { get; set; }

    public int? IdInstalacion { get; set; }

    public virtual ICollection<ControlesEmsObservacione> ControlesEmsObservaciones { get; set; } = new List<ControlesEmsObservacione>();

    public virtual ICollection<ControlesEmsPersona> ControlesEmsPersonas { get; set; } = new List<ControlesEmsPersona>();

    public virtual ControlesEmsCfestado? Estado1 { get; set; }

    public virtual ControlesEmsCftipoRechazo? EstadoNavigation { get; set; }

    public virtual ControlesEmsTipo IdControlesEmsTipoNavigation { get; set; } = null!;

    public virtual Empresa? IdEmpresaNavigation { get; set; }

    public virtual ControlesEmsCrInstalacion? IdInstalacionNavigation { get; set; }

    public virtual ControlesEmsCrLugarControl? IdLugarControlNavigation { get; set; }

    public virtual ControlesEmsCrSentidoRutum? IdSentidoRutaNavigation { get; set; }

    public virtual TipoVehiculo? IdTipoVehiculoNavigation { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ControlesEmsCftipoSolicitud? IdtipoSolicitudNavigation { get; set; }
}
