using GuitarPick.DataLayer.DataModels;
using GuitarPick.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;

namespace GuitarPick.DataLayer.Repositories
{
    public class LINQOrdersRepository : IOrdersRepository
    {
        private GuitarPickDBDataContext _DataContext = new GuitarPickDBDataContext();

        Orders Get(string username)
        {
            Orders orders = null;
            OrderDO orderDO = _DataContext.Orders_Get(username).SingleOrDefault();
            if (orderDO != null)
            {
                orders = new Orders();
                orders.OrderID = orderDO.OrderID;
                orders.OrderID = orderDO.FirstName;
                orders.OrderID = orderDO.LastName;
                orders.OrderID = orderDO.username;
                orders.OrderID = orderDO.ProductName;
                orders.OrderID = orderDO.Qty;
                orders.OrderID = orderDO.Price;
                orders.OrderID = orderDO.TotalPrice;
                orders.OrderID = orderDO.Address;
                orders.OrderID = orderDO.City;
                orders.OrderID = orderDO.State;
                orders.OrderID = orderDO.Zip;
                orders.OrderID = orderDO.PaymentType;
            }
            return orders;
        }

        void SaveOrders(Orders orders)
        {
            if (orders.OrderID == 0)
            {
                _DataContext.Orders_InsertUpdate(null, orders.FirstName, orders.LastName, orders.username, orders.ProductName, orders.Qty, orders.Price, orders.TotalPrice, orders.Address, orders.City, orders.State, orders.PaymentType);
            }
            else
            {
                _DataContext.Orders_InsertUpdate(orders.OrderID, orders.FirstName, orders.LastName, orders.username, orders.ProductName, orders.Qty, orders.Price, orders.TotalPrice, orders.Address, orders.City, orders.State, orders.PaymentType);
            }
        }
    }
}