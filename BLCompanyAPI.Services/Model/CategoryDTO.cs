﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Services.Model
{
    public class CategoryDTO
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
    }
}
