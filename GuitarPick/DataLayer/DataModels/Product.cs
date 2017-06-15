using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuitarPick.DataLayer.DataModels
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage ="We need to know the name of the product is about to go for sale on this awsome site")]
        [DisplayName("Prodcut Name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage ="We need to know a little about the product like color, brand, etc")]
        public string Description { get; set; }
        [Required(ErrorMessage ="As much as we would love to give things away for free we can't so please provide the price for the product")]
        public decimal Price { get; set;}
    }
}