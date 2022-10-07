using BLCompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Services
{
    public interface IStockRepo
    {
        public List<Stock> GetStocks();
        public Stock GetStock(int stockId);
    }
}
