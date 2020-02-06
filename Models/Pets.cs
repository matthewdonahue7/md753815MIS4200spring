using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace md753815MIS4200spring.Models
{
    public class Pets
    {
        [Key]
        public int petId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime petSince { get; set; }
        public ICollection<Visit> Visit { get; set; }
    }
}