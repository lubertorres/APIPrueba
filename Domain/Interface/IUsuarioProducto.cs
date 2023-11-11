using apiPrueba.Models;
using Azure;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace apiPrueba.Interface
{
    public interface IUsuarioProducto
    {
        public Task<List<Producto>> BusqUsuarioProduct(Guid idUsuarioU);

    }

    public class UsuarioProductoR : IUsuarioProducto
    {
        public PruebaContext _context;

        public UsuarioProductoR(PruebaContext context)
        {
            _context = context;
        }

        public Task<List<Producto>> BusqUsuarioProduct(Guid idUsuarioU)
        {

            var resultado = _context.Usuario
              .Where(usuario => usuario.IdUsuario == idUsuarioU)
              .Join(_context.UsuarioProducto,
                    usuario => usuario.IdUsuario,
                    usuarioProducto => usuarioProducto.IdUsuario,
                    (usuario, usuarioProducto) => new
                    {
                        Usuario = usuario,
                        UsuarioProducto = usuarioProducto
                    })
              .Join(_context.Producto,
                    combined => combined.UsuarioProducto.IdProducto,
                    producto => producto.IdProducto,
                    (combined, producto) => new
                    {
                        Producto = producto
                    })
              .Select(resultadoFinal => resultadoFinal.Producto);

            return resultado.ToListAsync();
        }

    }

}
