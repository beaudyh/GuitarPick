﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuitarPick.DataLayer.DataModels
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string Picture { get;  set;}

        public decimal Price { get; set;}
    }
}