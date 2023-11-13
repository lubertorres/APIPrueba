using apiPrueba.Domain.Interface;
using apiPrueba.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace apiPrueba.Aplication.Controllers
{

    [Route("/api/v1/shopping-cart")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ICartService _shoppingCartService;

        public ShoppingCartController(ICartService cartService)
        {
            _shoppingCartService = cartService;
        }

        [HttpPut("{id}")]
        public OkObjectResult UpdateShoppingCart(int id, [FromBody] CartUpdate cartUpdate)
        {
            Console.WriteLine(string.Format("BODY{0}", cartUpdate));
            _shoppingCartService.Update(id, cartUpdate);
            return Ok("update");
        }

    }


}
