using BLCompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Services.Model
{
    public class FlowerDTO
    {
        public int flowerId { get; set; }
        public string flowerName { get; set; }
        public Decimal price { get; set; }
        public int stock { get; set; }
        public String category { get; set; }

    }
}
