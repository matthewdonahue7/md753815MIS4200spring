﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace md753815MIS4200spring.Models
{
    public class Product
    {
        public int productID { get; set; }
        public string description { get; set; }
        public decimal unitCost { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<orderDetail> OrderDetail { get; set; }
        public int supplierId { get; set; }
    }
}