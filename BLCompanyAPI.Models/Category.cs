using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Models
{
    public class Category
    {
        [Key]
        [Required]
        [MaxLength(10)]
        public int categoryId { get; set; }
        [Required]
        [MaxLength(100)]
        public string categoryName { get; set; }
        [MaxLength(200)]
        public string categoryDescription { get; set; }
        public ICollection<Flower> Flowers { get; set; } = new List<Flower>();
        /*
        public Flower flower { get; set; }
        public int flowerId { get; set; }*/
    }
}
