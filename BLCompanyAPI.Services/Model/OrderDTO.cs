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
    public class OrderDTO
    {
        public int orderId { get; set; }
        public string customerName { get; set; }
        public string customerPhone { get; set; }
        public DateTime dilevaryDate { get; set; }
        public string place { get; set; }
       // [JsonIgnore]
       // public ICollection<FlowerDTO> flowers { get; set; } = new List<FlowerDTO>();

    }
}
