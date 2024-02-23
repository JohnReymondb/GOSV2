using GOS.Server.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GOS.Server.Interfaz
{
    public interface SolicitudMovimientos :Base<AutorizacionMovimiento>
    {
        Task<AutorizacionMovimiento> Registrar(AutorizacionMovimiento modelo);

       
    }
}
