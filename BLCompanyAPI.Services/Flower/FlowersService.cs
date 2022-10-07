using BLCompanyAPI.DataAccess;
using BLCompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Services
{
    public class FlowersService : IFlowerRepo
    {
        private readonly BLCompanyDbContext _context = new BLCompanyDbContext();

        public Flower addNewFlower(Flower flower)
        {
           _context.Flowers.Add(flower);
           _context.SaveChanges();
            return _context.Flowers.Find(flower.flowerId);
        }

        public List<Flower> AllFlowers()
        {
            return _context.Flowers.ToList();
        }

        public Flower GetFlower(int flowerId)
        {
            var flower = _context.Flowers.Find(flowerId);
            return flower;
        }

        public List<Flower> GetFlowerByCategoryId(int categoryId)
        {
            return _context.Flowers.Where(f => f.categoryId == categoryId).ToList();
        }

       /* public Flower GetUiqueFlower(int categoryId, int flowerId)
        {
           return _context.Flowers.Find(categoryId, flowerId);
            
        }*/

         
    }
}
