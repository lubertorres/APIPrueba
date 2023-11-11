using apiPrueba.Interface;
using apiPrueba.Dtos;
using Microsoft.AspNetCore.Mvc;
using apiPrueba.Models;


namespace apiPrueba.Controllers
{
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private IProducto _producto;
        public ProductoController(IProducto producto)
        {
            _producto = producto;
        }
        [HttpPost]
        [Route("insertar-producto")]
        public async Task<bool> InsertarProducto([FromBody] ProductoDto productoDto)
        {
            var response = await _producto.InsertarProducto(productoDto);
            return response;
        }



        [HttpPut]
        [Route("editar-estado-producto")]
        public async Task<bool> EditarEstado([FromQuery] Guid idProducto, [FromQuery] Guid idEstadoProductoR)
        {
            var response = await _producto.EditarEstado(idProducto, idEstadoProductoR);
            return response;
        }

    }
}
