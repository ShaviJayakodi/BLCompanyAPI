  using BLCompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BLCompanyAPI.Services.Model
{
    public class FlowerDTO
    {
        public int flowerId { get; set; }
        public string flowerName { get; set; }
        public Decimal price { get; set; }
        //public int stock { get; set; }
        public int categoryId { get; set; }
        [JsonIgnore]
        public ICollection<StockDTO> stocks { get; set; } = new List<StockDTO>();

    }
}
