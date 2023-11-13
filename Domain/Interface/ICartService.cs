using apiPrueba.Domain.Models;
using apiPrueba.infraestructure.entity;

namespace apiPrueba.Domain.Interface
{
    public interface ICartService
    {
        public void Update(int id, CartUpdate user);
    }

}
