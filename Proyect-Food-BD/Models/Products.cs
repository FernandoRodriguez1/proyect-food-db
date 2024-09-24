using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace Proyect_Food_BD.Models
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        public int ProductName { get; set; }
        [Required]
        public int ProductStock { get; set; }

        // [ForeignKey("Stock")]
        // public Stock Stock { get; set; }
        // public int Stockid { get; set; }

        
    }
}

