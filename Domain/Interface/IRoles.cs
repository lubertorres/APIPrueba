using apiPrueba.Dtos;
using apiPrueba.Models;

namespace apiPrueba.Interface
{
    public interface IRoles
    {
        Task<bool> InsertarRol(RolesDto rolesDto);
    }

    public class RolesR : IRoles
    {
        public PruebaContext _context;

        public RolesR(PruebaContext context)
        {
            _context = context;

        }

        public async Task<bool> InsertarRol(RolesDto rolesDto)
        {

                var response = await _context.Roles.AddAsync(new Roles
                {
                    IdRol = Guid.NewGuid(),
                    Nombre = rolesDto.Nombre,
                    Descripcion = rolesDto.Descripcion
                });
                await _context.SaveChangesAsync();

                if (response != null)
                {
                    return true;
                }
                return false;


        }


    }
}
