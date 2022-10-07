using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Models
{
    public class Flower
    {
        [Key]
        [Required]
        [MaxLength(10)]
        public int flowerId { get; set; }
        [Required]
        [MaxLength(50)]
        public string flowerName { get; set; }
        [MaxLength(200)]
        public string flowerDescription { get; set; }
        [MaxLength(1)]
        public StatusValue status { get; set; } = StatusValue.Active;
        [MaxLength(50)]
        public Decimal price { get; set; }

        public Category category { get; set; }
        public int categoryId { get; set; }
        public Stock Stock{ get; set; }
       
    }
}
