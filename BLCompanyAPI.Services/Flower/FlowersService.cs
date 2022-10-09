using AutoMapper;
using BLCompanyAPI.DataAccess;
using BLCompanyAPI.Models;
using BLCompanyAPI.Services.Model;
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
        private readonly IMapper _mapper;

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

        public void DeleteFlower(Flower flower)
        {
            _context.Remove(flower);
            _context.SaveChanges();
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

        public void UpdateFlower(Flower flower)
        {
            _context.Remove(flower);
            _context.SaveChanges();
        }

      


    }
}
