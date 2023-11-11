using apiPrueba.Models;
using apiPrueba.Dtos;

namespace apiPrueba.Interface
{
    public interface IEstadoProducto
    {
        public Task<bool> insertarEstadoProducto(EstadoProductoDto estadoProducto);
    }
}