
using apiPrueba.Dtos;
using apiPrueba.Interface;
using Microsoft.AspNetCore.Mvc;

namespace apiPrueba.Aplication.Controllers
{

    [ApiController]
    [Route("/api/v1/estado-productos")]
    public class EstadoProductoController : ControllerBase
    {

        private IEstadoProducto _estadoProducto;

        public EstadoProductoController(IEstadoProducto estadoProductoController)
        {

            _estadoProducto = estadoProductoController;
        }


        [HttpGet("{id}")]
        public void findByEmail(string id)
        {
            Console.WriteLine(id);
        }

        [HttpGet("all")]
        public void findAll()
        {
            Console.WriteLine("All");
        }

        [HttpPost]
        public async Task<IActionResult> insertarEstadoProducto([FromBody] EstadoProductoDto estadoProducto)
        {
            var response = await _estadoProducto.insertarEstadoProducto(estadoProducto);
            return Created("", response);
        }


    }
}
