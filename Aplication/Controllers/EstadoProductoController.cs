
using apiPrueba.Dtos;
using apiPrueba.Interface;
using Microsoft.AspNetCore.Mvc;

namespace apiPrueba.Aplication.Controllers
{

    [ApiController]
    public class EstadoProductoController : ControllerBase
    {

        private IEstadoProducto _estadoProducto;

        public EstadoProductoController(IEstadoProducto estadoProductoController)
        {

            _estadoProducto = estadoProductoController;
        }


        [HttpPost]
        [Route("enviar-estado-producto")]
        public async Task<IActionResult> insertarEstadoProducto([FromBody] EstadoProductoDto estadoProducto)
        {
            var response = await _estadoProducto.insertarEstadoProducto(estadoProducto);
            return Created("", response);
        }


    }
}
