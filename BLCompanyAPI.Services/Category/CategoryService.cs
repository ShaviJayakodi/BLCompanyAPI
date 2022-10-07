using BLCompanyAPI.DataAccess;
using BLCompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Services
{
    public class CategoryService : ICategoryRepo
    {
         private readonly BLCompanyDbContext _context = new BLCompanyDbContext();
        public List<Category> GetCategories()
        {
          return _context.Categories.ToList();
        }

        public Category GetCategory(int categoryId)
        {
           var foundCategory = _context.Categories.Find(categoryId);
            return foundCategory;
        }

        public Category AddCategory(Category category)
        {
            
            _context.Categories.Add(category);
            _context.SaveChanges();

            return _context.Categories.Find(category.categoryId);


        }

    

    }
}
