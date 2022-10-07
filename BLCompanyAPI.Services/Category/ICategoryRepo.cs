using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLCompanyAPI.Models;

namespace BLCompanyAPI.Services
{
    public interface ICategoryRepo
    {
        public List<Category> GetCategories();

        public Category GetCategory(int categoryId);
    }
}
