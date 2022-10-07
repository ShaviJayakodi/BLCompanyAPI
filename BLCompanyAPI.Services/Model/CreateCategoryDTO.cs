using BLCompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Services.Model
{
    public class CreateCategoryDTO
    {
        public string categoryName { get; set; }
        public string categoryDescription { get; set; }
     
    }
}
