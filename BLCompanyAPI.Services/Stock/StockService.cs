using BLCompanyAPI.DataAccess;
using BLCompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Services
{
    public class StockService : IStockRepo
    {
        private readonly BLCompanyDbContext _context = new BLCompanyDbContext();

        public List<Stock> GetStocks()
        {
            return _context.Stocks.ToList();
        }

        public List<Stock> GetStocksByFlowerID(int flowerID)
        {
            return _context.Stocks.Where(s=> s.FlowerId==flowerID).ToList();
        }

        public Stock GetUniqueStock(int flowerId, int stockId)
        {
            return _context.Stocks.FirstOrDefault(s=>s.stockId==stockId && s.FlowerId==flowerId);
        }
        /*
public Stock addNewStock(int flowerId, Stock stock)
{

   stock.FlowerId = flowerId;
   _context.Stocks.Add(stock);
   _context.SaveChanges();

   return _context.Stocks.Find(stock.stockId);
}



public Stock GetStock(int stockId)
{
   return _context.Stocks.Find(stockId);

}

public List<Stock> GetStocks()
{
   return _context.Stocks.ToList();
}*/
    }
}
