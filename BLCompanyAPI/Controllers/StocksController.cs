using AutoMapper;
using BLCompanyAPI.Models;
using BLCompanyAPI.Services;
using BLCompanyAPI.Services.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BLCompanyAPI.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IStockRepo _stockService;
        private readonly IMapper _mapper;
        public StocksController(IStockRepo stockService, IMapper mapper)
        {
            _stockService = stockService;
            _mapper = mapper;

        }


        [HttpGet]
        public ActionResult<ICollection<StockDTO>> getAllStock()
        {
            var stocks = _stockService.GetStocks();
            var mappedStocks = _mapper.Map<ICollection<StockDTO>>(stocks);
            return Ok(mappedStocks);
        }

        [HttpGet("flower/{flowerId}/stock",Name ="GetStockByFlowerId")]
        public ActionResult<ICollection<StockDTO>> GetStockByFlowerId(int flowerId)
        {
            var stockByFlowerId = _stockService.GetStocksByFlowerID(flowerId);
            var mappedStocks = _mapper.Map<ICollection<StockDTO>>(stockByFlowerId);
            return Ok(mappedStocks);
        }

        [HttpGet("flower/{flowerId}/stock/{stockId}" , Name ="GetUniqueStock")]
        public ActionResult<StockDTO> GetUniqueStock(int flowerId, int stockId)
        {
            var uniqueStock = _stockService.GetUniqueStock(flowerId,stockId);
            if (uniqueStock == null)
            {
                return NotFound("Stock Not Found");
            }
            var mappedUnique = _mapper.Map<StockDTO>(uniqueStock);
            return Ok(mappedUnique);

        }

        [HttpGet("{stockId}",Name ="GetStockByStockId")]
        public ActionResult<StockDTO> GetStockByStockId(int stockId)
        {
            var stock = _stockService.GetStock(stockId);
            if (stock == null)
            {
                return NotFound("Stock Not Found");
            }
            var mappedStock = _mapper.Map<StockDTO>(stock);
            return Ok(mappedStock);
        }

        [HttpPost("flower/{flowerId}/stock" , Name ="AddStockForFlowerId")]
        public ActionResult<StockDTO> AddStockForFlowerId (int flowerId , CreateStockDTO stock)
        {
            var stockEntity = _mapper.Map<Stock>(stock);
            var newStock = _stockService.AddStockForFlowerId(flowerId,stockEntity);

            var stockForReturn = _mapper.Map<StockDTO>(newStock);
            return CreatedAtRoute("GetUniqueStock", new { flowerId = flowerId, stockId = stockForReturn.stockId }, stockForReturn);
        }

        [HttpPut("flower/{flowerId}/stock/{stockId}" , Name ="UpdateUniqueStock")]
        public ActionResult UpdateUniqueStock(int flowerId , int stockId,UpdateStockDTO stock)
        {
            var updateStock = _stockService.GetUniqueStock(flowerId ,stockId);
            if(updateStock== null)
            {
                return NotFound();
            }
            var mappedStock = _mapper.Map(stock,updateStock);
            _stockService.UpdateUniqueStock(mappedStock);
            return NoContent();

        }

        [HttpDelete("{stockId}", Name = "DeleteStockById")]
        public ActionResult DeleteStockById(int stockId)
        {
            var deleteStock = _stockService.GetStock (stockId);
            if (deleteStock == null)
            {
                return NotFound();
            }
            _stockService.DeleteStock(deleteStock);
            return NoContent();
        }

       /* [HttpGet("{stockId}" , Name = "getScockById")]
        public ActionResult<StockDTO> getScockById(int stockId)
        {
            var stock = _stockService.GetStock(stockId);
            var mappedStock = _mapper.Map<StockDTO>(stock);
            return Ok(mappedStock);
        }*/


        /* [HttpPost("{flowerId}")]
         public ActionResult<StockDTO> addNewStocko(int flowerId,CreateStockDTO stock)
         {
             var stockEntity = _mapper.Map<Stock>(stock);
             var newStock =  _stockService.addNewStock(flowerId,stockEntity);
             var stockForReturn  = _mapper.Map<StockDTO>(newStock);
             return CreatedAtRoute("getScockById", new { stockId = stockForReturn.stockId }, stockForReturn);

         }*/
    }
}
