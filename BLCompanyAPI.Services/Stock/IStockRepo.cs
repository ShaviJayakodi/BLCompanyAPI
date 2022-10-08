using BLCompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Services
{
    public interface IStockRepo
    {/*
        public List<Stock> GetStocks();
        public Stock GetStock(int stockId);

        public Stock addNewStock(int flowerId, Stock stock);
        */

        public List<Stock> GetStocks();
        public List<Stock> GetStocksByFlowerID(int flowerID);
        public Stock GetUniqueStock(int flowerId ,int stockId);
    }
}
