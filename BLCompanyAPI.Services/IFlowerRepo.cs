using BLCompanyAPI.Model;
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
    }
}
