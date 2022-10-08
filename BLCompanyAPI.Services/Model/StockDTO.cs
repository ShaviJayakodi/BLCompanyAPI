using BLCompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Services.Model
{
    public class StockDTO
    {
        
        public int stockId { get; set; }
        public string stockName { get; set; }
        public int quientity { get; set; }
        public int FlowerId { get; set; }
       
    }
}
