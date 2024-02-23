using GOS.Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GOS.Server.Interfaz
{
    public class BaseClass<Tmodel> : Base<Tmodel> where Tmodel : class
    {

        private readonly GosContext _context;

        public BaseClass(GosContext context)
        {
            _context = context;
        }

        public async Task<Tmodel> Obtener(Expression<Func<Tmodel, bool>> filtro)
        {
            try
            {
                Tmodel model = await _context.Set<Tmodel>().FirstOrDefaultAsync(filtro);
                return model;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Tmodel> Crear(Tmodel modelo)
        {
            try {
                _context.Set<Tmodel>().Add(modelo);
                await _context.SaveChangesAsync();
                return modelo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Editar(Tmodel modelo)
        {
            try {
                _context.Set<Tmodel>().Update(modelo);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Eliminar(Tmodel modelo)
        {
            try
            {
                _context.Set<Tmodel>().Remove(modelo);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IQueryable<Tmodel>> Consultar(Expression<Func<Tmodel, bool>> filtro = null)
        {
            try
            {
                IQueryable<Tmodel> queryModel = filtro == null ? _context.Set<Tmodel>(): _context.Set<Tmodel>().Where(filtro);
                return queryModel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
