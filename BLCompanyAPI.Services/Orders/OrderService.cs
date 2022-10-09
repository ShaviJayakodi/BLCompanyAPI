using BLCompanyAPI.DataAccess;
using BLCompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Services.Orders
{
    public class OrderService : IOrderRepo
    {
        private readonly BLCompanyDbContext _context = new BLCompanyDbContext();
        public Order AddNewOrder(Order order)
        {
           _context.Orders.Add(order);
            _context.SaveChanges();
            return _context.Orders.Find(order.orderId);
        }

        public void deleteOrder(Order order)
        {
           _context.Remove(order);
            _context.SaveChanges();
        }

        public List<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders.Find(orderId);
        }

        public void updateOrder(Order order)
        {
            _context.SaveChanges();
        }
    }
}
