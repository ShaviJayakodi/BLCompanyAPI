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

        public Stock AddStockForFlowerId(int flowerID, Stock stock)
        {
            stock.FlowerId = flowerID;
            _context.Stocks.Add(stock);
            _context.SaveChanges();

            return _context.Stocks.Find(stock.stockId);
        }

        public void DeleteStock(Stock stock)
        {
           _context.Remove(stock);
            _context.SaveChanges();
        }

        public void DeleteStocksByFlowerId(int flowerId)
        {
            var FlowersForDelete = _context.Stocks.Where(s => s.FlowerId == flowerId).ToList();
            _context.Remove(FlowersForDelete);
            _context.SaveChanges();
        }

        public Stock GetStock(int stockId)
        {
             return _context.Stocks.Find(stockId);
        }

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

        public void UpdateUniqueStock(Stock stock)
        {
            _context.SaveChanges();
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
