using apiPrueba.Domain.Models;
using apiPrueba.infraestructure.entity;

namespace apiPrueba.Domain.Interface
{
    public interface IUserService
    {
        public UserEntity Save(UserCreate user);
        public List<UserEntity> GetAll();
    }
    
}
