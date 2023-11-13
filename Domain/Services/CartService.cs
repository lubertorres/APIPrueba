using apiPrueba.Domain.Interface;
using apiPrueba.Domain.Models;
using apiPrueba.infraestructure.entity;
using apiPrueba.Infraestructure.Context;

namespace apiPrueba.Domain.Services
{

    public class CartService : ICartService
    {
        private ECommerceContext _context;
        public CartService(ECommerceContext eCommerceContext)
        {
            _context = eCommerceContext;
        }

        public void Update(int id, CartUpdate cartUpdate)
        {
            cleanCart(id);
            updateShoppingCart(id, cartUpdate);
        }

        private void updateShoppingCart(int id, CartUpdate cartUpdate)
        {
            var shoppingCart = _context.ShoppingCarts.FirstOrDefault(u => u.UserID == id);

            if (shoppingCart != null)
            {
                var items = cartUpdate.Items.Select(i => new ItemEntity
                {
                    ShoppingCartID = id,
                    ProductName = i.Name,
                    Quantity = i.Quantity

                }).ToList();

                _context.Items.AddRange(items);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Cart not found");
            }
        }

        private void cleanCart(int id)
        {
            var items = _context.Items.Where(i => i.ShoppingCartID == id).ToList();

            if (items.Any())
            {
                // Remove the items from the database
                _context.Items.RemoveRange(items);
                _context.SaveChanges();
            }
        
        }
    }

}