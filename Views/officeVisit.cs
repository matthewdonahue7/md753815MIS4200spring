using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace md753815MIS4200spring.Views
{
    public class officeVisit
    {
        
        public int officeVisitID { get; set; }
        public string description { get; set; }
        public DateTime officeVisitDate { get; set; }
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        //public ICollection<OrderDetail> OrderDetail { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int petID { get; set; }
        public virtual Pet Pet { get; set; }
    }
}
