using BLCompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Services.Orders
{
    public interface IOrderRepo
    {
        public Order AddNewOrder (Order order);
        public List<Order> GetAllOrders ();
        public Order GetOrderById (int orderId);
        public void updateOrder(Order order);
        public void deleteOrder(Order order );
    }
}
