using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Models
{
    public class Order
    {
        [Key]
        [Required]
        public int orderId { get; set; }
        [Required]
        public string customerName { get; set; }
        [Required]
        public string customerPhone { get; set; }
        [Required]
        public DateTime dilevaryDate { get; set; }
        [Required]
        public string place { get; set; }
        public ICollection<Flower> flowers { get; set; } = new List<Flower>();

    }
}
