using GuitarPick.DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuitarPick.Models
{
    public class OrdersModel
    {
        public List<int> Cart { get; set; }
        public List<USState> States { get; set; }
        public int OrderID { get; set; }
        [Required(ErrorMessage = "Enter the first name of who is recieving the package")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter the last name of who is recieving the package")]
        public string LastName { get; set; }
        public string username { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        [Required(ErrorMessage = "Enter in the address to ship to")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Enter in the city to ship to")]
        public string City { get; set; }
        [Required(ErrorMessage = "Pick a state to ship to")]
        public string State { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Enter in a valid zip code")]
        public string Zip { get; set; }
        public string PaymentType { get; set; }
    }
}