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
        private GuitarPickOrdersDBDataContext _DataContext = new GuitarPickOrdersDBDataContext();

       public List<Orders> Get(string username)
        {
            List<Orders> orders = new List<Orders>();
            ISingleResult<OrderDO> orderDOs = _DataContext.Orders_Get(username);
            foreach (var o in orderDOs)
            {
                Orders order = new Orders();
                order.OrderID = o.OrderID;
                order.FirstName = o.FirstName;
                order.LastName = o.LastName;
                order.username = o.username;
                order.ProductName = o.ProductName;
                order.Qty = o.Qty;
                order.Price = o.Price;
                order.TotalPrice = o.TotalPrice;
                order.Address = o.Address;
                order.City = o.City;
                order.State = o.State;
                order.Zip = o.Zip;
                order.PaymentType = o.PaymentType;
                orders.Add(order);
            }
            return orders;
        }

       public void SaveOrders(Orders orders)
        {
            if (orders.OrderID == 0)
            {
                _DataContext.Orders_InsertUpdate(null, orders.FirstName, orders.LastName, orders.username, orders.ProductName, orders.Qty, orders.Price, orders.TotalPrice, orders.Address, orders.City, orders.State, orders.Zip, orders.PaymentType);
            }
            else
            {
                _DataContext.Orders_InsertUpdate(orders.OrderID, orders.FirstName, orders.LastName, orders.username, orders.ProductName, orders.Qty, orders.Price, orders.TotalPrice, orders.Address, orders.City, orders.State, orders.Zip, orders.PaymentType);
            }
        }
        public Orders Get_Edit(int id)
        {
            Orders orders = null;
            OrderDO orderDO = _DataContext.Orders_Get_Edit(id).SingleOrDefault();
            if (orderDO != null)
            {
                orders = new Orders();
                orders.OrderID = orderDO.OrderID;
                orders.FirstName = orderDO.FirstName;
                orders.LastName = orderDO.LastName;
                orders.username = orderDO.username;
                orders.ProductName = orderDO.ProductName;
                orders.Qty = orderDO.Qty;
                orders.Price = orderDO.Price;
                orders.TotalPrice = orderDO.TotalPrice;
                orders.Address = orderDO.Address;
                orders.City = orderDO.City;
                orders.State = orderDO.State;
                orders.Zip = orderDO.Zip;
                orders.PaymentType = orderDO.PaymentType;
            }
            return orders;
        }
    }
}