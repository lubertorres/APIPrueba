
using apiPrueba.infraestructure.entity;
using apiPrueba.Infraestructure.Context;
using apiPrueba.Interface;

namespace apiPrueba.Domain.Services
{

    public class UserService : IUserServices
    {
        private ECommerceContext _context;
        public UserService(ECommerceContext eCommerceContext)
        {
            _context = eCommerceContext;
        }

        public UserEntity Save(UserEntity user)
        {
            var result = _context.Add(user);
            _context.SaveChanges();
            return result.Entity;
        }

        public List<UserEntity> GetAll()
        {
            return _context.Users.ToList();
        }
    }

}