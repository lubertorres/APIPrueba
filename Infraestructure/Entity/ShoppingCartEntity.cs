using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiPrueba.infraestructure.entity
{
    public class ShoppingCartEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShoppingCardID { get; set; }

        [ForeignKey("UserID")]
        public int UserID { get; set; }

        public virtual Collection<ItemEntity> Items { get; set; }
        public virtual UserEntity User { get; set; }

    }
}

