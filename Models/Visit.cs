using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace md753815MIS4200spring.Models
{
    public class Visit
    {
        [Key]
        public int visitId { get; set; }
        public int petId { get; set; }
        public string description { get; set; }

        public DateTime visitDate { get; set; }
        
        public virtual Pets Pets { get; set; }

    }
}