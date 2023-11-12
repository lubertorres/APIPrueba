using apiPrueba.infraestructure.entity;
using Microsoft.EntityFrameworkCore;

namespace apiPrueba.Infraestructure.Context
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ShoppingCartEntity> ShoppingCarts { get; set; }
        public DbSet<ItemEntity> Items { get; set; }
    }
}

