using BLCompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Services.Model
{
    public class UpdateFlowerDTO
    {
        public string flowerName { get; set; }
        public string flowerDescription { get; set; }
        public StatusValue status { get; set; } = StatusValue.Active;
        public Decimal price { get; set; }
        public int categoryId { get; set; }
       
    }
}
