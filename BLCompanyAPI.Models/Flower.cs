using System.ComponentModel.DataAnnotations;
using BLCompanyAPI.Model;

namespace BLCompanyAPI.Model
{
    public class Flower
    {
        [Key]
        [Required]
        public int flowerId { get; set; }
        [Required]
        public string flowerName { get; set; }
        public string flowerDescription { get; set; }
        public StatusValue status { get; set; } = new StatusValue();

       /* public Category category { get; set; }
        public int categoryId { get; set; }*/
    }
}
 