using apiPrueba.Domain.Interface;
using apiPrueba.Domain.Models;
using apiPrueba.infraestructure.entity;
using apiPrueba.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace apiPrueba.Domain.Services
{

    public class UserService : IUserService
    {
        private ECommerceContext _context;
        public UserService(ECommerceContext eCommerceContext)
        {
            _context = eCommerceContext;
        }

        public UserEntity Save(UserCreate user)
        {
            var userEntity = new UserEntity()
            {
                Username = user.Username,
                ShoppingCart = new ShoppingCartEntity()

            };
            var result = _context.Users.Add(userEntity);
            _context.SaveChanges();
            return result.Entity;
        }

        public List<UserEntity> GetAll()
        {
            return _context.Users
                .Include(u => u.ShoppingCart)
                .ThenInclude(sc => sc.Items)
                .ToList();
        }
    }

}