using apiPrueba.Domain.Exceptions;
using apiPrueba.Dtos;
using apiPrueba.Interface;
using apiPrueba.Models;
using Microsoft.AspNetCore.Mvc;

namespace apiPrueba.Domain.Services
{
    public class EstadoProductoP : IEstadoProducto
    {
        public PruebaContext _context;

        public EstadoProductoP(PruebaContext context)
        {
            _context = context;

        }

        public async Task<bool> insertarEstadoProducto(EstadoProductoDto estadoProducto)
        {
            //if (estadoProducto.Nombre != "Luber")
            //{
                
            //}

            //Console.WriteLine("Esto jamas se va a ejecutar");
            
            var response = await _context.EstadoProducto.AddAsync(new EstadoProducto
            {
                IdEstadoProducto = Guid.NewGuid(),
                Nombre = estadoProducto.Nombre,
                Descripcion = estadoProducto.Descripcion
            });


            await _context.SaveChangesAsync();
            return true;
        }


    }
}
