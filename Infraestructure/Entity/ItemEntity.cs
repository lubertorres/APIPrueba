using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiPrueba.infraestructure.entity
{
    public class ItemEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }


        [ForeignKey("ShoppingCartID")]
        public int ShoppingCartID { get; set; }

        public ShoppingCartEntity ShoppingCart { get; set; }

    }
}

