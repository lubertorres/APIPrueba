using apiPrueba.Dtos;
using apiPrueba.Interface;
using Microsoft.AspNetCore.Mvc;

namespace apiPrueba.Controllers
{
    [ApiController]
    public class RolesController : ControllerBase
    {

        private IRoles _roles;

        public RolesController(IRoles roles)
        {
            _roles = roles;
        }

        [HttpPost]
        [Route("insertar-rol")]
        public async Task<bool> InsertarRol([FromBody] RolesDto rolesDto)
        {
            var response = await _roles.InsertarRol(rolesDto);

            return response;
                                                   
        }


        
    }
}
