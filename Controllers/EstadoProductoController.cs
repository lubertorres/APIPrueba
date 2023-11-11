using apiPrueba.Dtos;
using apiPrueba.Interface;
using apiPrueba.Models;
using Microsoft.AspNetCore.Mvc;

namespace apiPrueba.Controllers
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
        public async Task<bool> insertarEstadoProducto([FromBody] EstadoProductoDto estadoProducto)
        {

            var response = await _estadoProducto.insertarEstadoProducto(estadoProducto);
            return response;

        }


    }
}
