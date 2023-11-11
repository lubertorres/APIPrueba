using apiPrueba.Interface;
using apiPrueba.Models;
using Microsoft.AspNetCore.Mvc;

namespace apiPrueba.Controllers
{
    [ApiController]
    public class UsuarioProductoController : ControllerBase
    {
        private IUsuarioProducto _usuario;

        public UsuarioProductoController(IUsuarioProducto usuario)
        {
            _usuario = usuario;
        }
        //Hasta aquì
        [HttpGet]
        [Route("usuario-producto")]
        public Task<List<Producto>> BusqUsuarioProduct([FromQuery] Guid idUsuarioU)
        {
            var response = _usuario.BusqUsuarioProduct(idUsuarioU);
            return response;
        }


    }
}
