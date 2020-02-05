using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace md753815MIS4200spring.Models
{
    public class Orders
    {
        [Key]
        public int orderNum { get; set; }
        public int description { get; set; }
        public DateTime orderDate { get; set; }
        public int customerId { get; set; }
        public virtual customer customer{ get; set; }


    }
}