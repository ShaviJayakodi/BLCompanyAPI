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

        public List<Flower> AllFlowers()
        {
            return _context.Flowers.ToList();
        }

        public Flower GetFlower(int flowerId)
        {
            var flower = _context.Flowers.Find(flowerId);
            return flower;
        }       
    }
}
