using BLCompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Services.Model
{
    public class CreateOrderDTO
    {
    
        
        public string customerName { get; set; }
        public string customerPhone { get; set; }
        public DateTime dilevaryDate { get; set; }
        public string place { get; set; }
        
    }
}
