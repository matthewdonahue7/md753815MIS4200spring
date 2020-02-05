using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace md753815MIS4200spring.Views
{
    public class Pet
    {
        public int petID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime customerSince { get; set; }
        public ICollection<officeVisit> officeVisit { get; set; }
       // public string fullName
       // {
       //     get
        //    {
        //        return customerLastName + "," + customerFirstName;

        //    }
        ///}
    }
}


