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

            /*
              Flower newFlower = new Flower(); ;
              newFlower.flowerName = flower.flowerName;
              newFlower.flowerDescription = flower.flowerDescription;
              newFlower.price = flower.price;
              newFlower.categoryId = flower.categoryId;
              //newFlower.stock = flower.stock;
              var stockEntity = _context.Stocks.Add(flower.stock);
              var flowerForReturn = _mapper.Map<StockDTO>(stockEntity); 
              int id = flowerForReturn.stockId;
              newFlower.stockId = id;


              _context.Flowers.Add(newFlower);
             _context.SaveChanges();
              return _context.Flowers.Find(newFlower.flowerId);*/
            return flower;
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
