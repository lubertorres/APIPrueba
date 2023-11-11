using apiPrueba.Dtos;
using apiPrueba.Models;

namespace apiPrueba.Interface
{
    public interface IProducto
    {
        public Task<bool> InsertarProducto(ProductoDto productoDto);
        public Task<bool> EditarEstado(Guid idProducto, Guid idEstadoProducto);

    }

    public class ProductoP : IProducto
    {

        public PruebaContext _context;

        public ProductoP(PruebaContext context)
        {
            _context = context;
        }

        public async Task<bool> InsertarProducto(ProductoDto productoDto)
        {
            var response = await _context.Producto.AddAsync(new Models.Producto
            {

                IdProducto = Guid.NewGuid(),
                Nombre = productoDto.Nombre,
                Descripcion = productoDto.Descripcion, 
                Estado = productoDto.Estado,
                FechaCreacion = DateTime.Now,
                IdEstadoProducto = productoDto.IdEstadoProducto

            });
            await _context.SaveChangesAsync();

            if (response != null)
            {
                return true;
            }
            return false;
        }





        public async Task<bool> EditarEstado(Guid idProducto, Guid idEstadoProducto)
        {


                var response = await _context.Producto.FindAsync(idProducto);
                if (response != null)
                {
                    response.IdEstadoProducto = idEstadoProducto;
                await _context.SaveChangesAsync();
                    return true;
                }
                
                return false;
        }

    }


}
