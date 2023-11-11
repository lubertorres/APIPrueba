using apiPrueba.Interface;
using Microsoft.AspNetCore.Mvc;
using apiPrueba.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using apiPrueba.Dtos;
using Microsoft.EntityFrameworkCore;

namespace apiPrueba.Controllers
{
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuario _usuario;

        public UsuarioController(IUsuario usuario)
        {
            _usuario = usuario;
        }

        [HttpPost]
        [Route("insertar-usuario")]
        public async Task<bool> InsertarUsuario([FromBody] UsuarioDto usuario)
        {
            var response = await _usuario.InsertarUsuario(usuario);
            return response;
        }



        [HttpPost]
        [Route("enviar-varios-usuarios")]
        public async Task<bool> InsertarUsuarioVarios([FromBody] List<Usuario> usuario)
        {
            var response = await _usuario.InsertarUsuarioVarios(usuario);
            return response;
        }



        [HttpGet]
        [Route("filtrar-por-cedula")]
        public async Task<Usuario> FilterByCi([FromQuery] string cedula)
        {
            var response =  await _usuario.FilterByCi(cedula);
            return response;
        }





        [HttpPut]
        [Route("editar-usuario")]
        public async Task<bool> EditarUsuario([FromBody] UsuarioDto usuario)
        {
            var response = await _usuario.EditarUsuario(usuario);
            return response;
        }



    }
}
