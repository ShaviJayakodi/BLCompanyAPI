using AutoMapper;
using BLCompanyAPI.DataAccess;
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

    } 


}
