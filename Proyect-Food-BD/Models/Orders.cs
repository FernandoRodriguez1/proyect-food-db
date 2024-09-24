using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Proyect_Food_BD.Models
{
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal LastName { get; set; }
        public string? Description { get; set; }

        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public int UserId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EstimatedTime { get; set;}

}
