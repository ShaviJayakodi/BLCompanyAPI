using AutoMapper;
using BLCompanyAPI.DataAccess;
using BLCompanyAPI.DataAccess.Migrations;
using BLCompanyAPI.Models;
using BLCompanyAPI.Services.Model;
using BLCompanyAPI.Services.Orders;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BLCompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepo _orderService;
        private readonly IMapper _mapper;

        public OrdersController(IOrderRepo orderRepo, IMapper mapper) { 
            _mapper = mapper;
            _orderService = orderRepo;
           }

        [HttpGet]
        public ActionResult<ICollection<OrderDTO>> GetAllOrders()
        {
            var orders = _orderService.GetAllOrders();
            var mappedOrder = _mapper.Map<ICollection<OrderDTO>>(orders);
            return Ok(mappedOrder);
        }

        [HttpGet("{orderId}",Name ="GetOrderByOrderID")]
        public ActionResult<OrderDTO> GetOrderByOrderID(int orderId)
        {
            var order = _orderService.GetOrderById(orderId);
            if(order==null)
            {
                return NotFound();
            }
            var orderForReturn = _mapper.Map<OrderDTO>(order);  
            return Ok(orderForReturn);
        }

        [HttpPost]
        public ActionResult<OrderDTO> addNewOrder (CreateOrderDTO order)
        {
            var flowerEntity = _mapper.Map<Order>(order);
            var newOrder = _orderService.AddNewOrder(flowerEntity);
            var orderForReturn=_mapper.Map<OrderDTO>(newOrder);
            return CreatedAtRoute("GetOrderByOrderID", new {orderId = orderForReturn.orderId},orderForReturn);
        }

        [HttpPut("{orderId}" , Name ="UpdateOrderById")]
        public ActionResult UpdateOrderById(int orderId,UpdateOrderDTO order)
        {
            var orderUpdate = _orderService.GetOrderById(orderId);
            if( orderUpdate==null)
            {
                return NotFound();
            }
            var mappedOrder = _mapper.Map(order,orderUpdate);
            _orderService.updateOrder(mappedOrder);
            return NoContent();

        }
        [HttpDelete("{orderId}",Name ="DeleteOrderById")]
        public ActionResult DeleteOrderById (int orderId)
        {
            var orderForDelete = _orderService.GetOrderById(orderId);
            if (orderForDelete == null)
            {
                return NotFound();
            }
            _orderService.deleteOrder(orderForDelete);
            return NoContent();
        }

    } 


}
