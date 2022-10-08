using BLCompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Services.Model
{
    public class CreateStockDTO
    {    
        public string stockName { get; set; }
     
        public int quientity { get; set; }

      
    }
}
