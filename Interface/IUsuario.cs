using apiPrueba.Dtos;
using apiPrueba.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace apiPrueba.Interface
{
    public interface IUsuario
    {
        public Task<bool> InsertarUsuario(UsuarioDto usuario);
        public Task<bool> InsertarUsuarioVarios(List<Usuario> usuario);
        public Task<Usuario> FilterByCi(string cedula);
        public Task<bool> EditarUsuario(UsuarioDto usuario);
    }

    public class UsuarioR: IUsuario
    {
        //Constructor
        public PruebaContext _context;
        public UsuarioR(PruebaContext context)
        {
            _context = context;
        }



        public async Task<bool> InsertarUsuario(UsuarioDto usuario)
        {
            try
            {
                var response = await _context.Usuario.AddAsync(new Usuario
                {
                    IdUsuario = Guid.NewGuid(),
                    Nombre = usuario.Nombre,
                    Cedula = usuario.Cedula,
                    Edad = usuario.Edad,
                    IdRol = usuario.IRol,
                    FechaCreacion = DateTime.Now
                
                });
                await _context.SaveChangesAsync();
                if (response != null )
                {
                    return true;
                }

                    return true;
                }
            catch (Exception)
            {
                return false;
            }
        }


        public async Task<Usuario> FilterByCi(string cedula)
        {

            var resul = await _context.Usuario.Where(x => x.Cedula == cedula).FirstAsync();
            return resul;



        }


        public async Task<bool> InsertarUsuarioVarios(List<Usuario> usuario)
        {
            try
            {
                foreach (var res in usuario)
                {
                    await _context.Usuario.AddAsync(res);
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }




        public async Task<bool> EditarUsuario(UsuarioDto usuarioDto)
        {
            var response = await _context.Usuario.FindAsync(usuarioDto.IdUsuario);

            if (response != null)
            {
                response.Nombre = usuarioDto.Nombre;
                response.Edad = usuarioDto.Edad;
                _context.SaveChanges();
                return true;
            }
            return false;
        }




    }
}
