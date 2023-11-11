using apiPrueba.Models;
using apiPrueba.Dtos;

namespace apiPrueba.Interface
{
    public interface IEstadoProducto
    {


        public Task<bool> insertarEstadoProducto(EstadoProductoDto estadoProducto);
    }


    public class EstadoProductoP : IEstadoProducto
    {
        public PruebaContext _context;

        public EstadoProductoP(PruebaContext context)
        {
            _context = context;

        }

        public async Task<bool> insertarEstadoProducto(EstadoProductoDto estadoProducto)
        {
            var response = await _context.EstadoProducto.AddAsync(new EstadoProducto
            {
                IdEstadoProducto = Guid.NewGuid(),
                Nombre = estadoProducto.Nombre,
                Descripcion = estadoProducto.Descripcion
            });
            await _context.SaveChangesAsync();
            return true;
        }



    }
}
