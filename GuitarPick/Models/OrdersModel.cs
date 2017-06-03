using GuitarPick.DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuitarPick.Models
{
    public class OrdersModel
    {
        public List<USState> States { get; set; }
        public int OrderID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string username { get; set; }

        public string ProductName { get; set; }

        public int Qty { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string PaymentType { get; set; }
    }
}