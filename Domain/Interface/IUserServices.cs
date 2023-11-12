

using apiPrueba.infraestructure.entity;

namespace apiPrueba.Interface
{
    public interface IUserServices
    {
        public UserEntity Save(UserEntity user);
        public List<UserEntity> GetAll();
    }
    
}
