using BLCompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Services
{
    public interface IFlowerRepo
    {
        public List<Flower> AllFlowers();

        public Flower GetFlower(int flowerId);

        public List<Flower> GetFlowerByCategoryId(int categoryId);

        public Flower addNewFlower(Flower flower);
        public void UpdateFlower(Flower flower);

        public void DeleteFlower(Flower flower);
    }

}
