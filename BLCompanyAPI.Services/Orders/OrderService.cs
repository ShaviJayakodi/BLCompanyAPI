﻿using BLCompanyAPI.DataAccess;
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
            throw new NotImplementedException();
        }

        public void deleteOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public Order GetOrderById(int orderId)
        {
            throw new NotImplementedException();
        }

        public void updateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
