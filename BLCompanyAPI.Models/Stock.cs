using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Models
{
    public class Stock
    {
        [Key]
        [Required]
        [MaxLength(10)]
        public int stockId { get; set; }
        [MaxLength(100)]
        public string stockName { get; set; }
        [MaxLength(100)]
        public int quientity { get; set; }

        public Flower flower { get; set; }
        public int flowerId { get; set; }
    }
}
