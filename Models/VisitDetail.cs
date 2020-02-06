using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace md753815MIS4200spring.Models
{
    public class VisitDetail
    {

        public int visitDetailId { get; set; }
        public decimal price { get; set; }
        public int petId { get; set; }

        public int visitId { get; set; }
        public virtual Visit Visit { get; set; }
        public virtual Vets Vets { get; set; }



    }
}