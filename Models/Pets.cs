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
        public string fullName { get { return lastName + ", " + firstName; } }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Pet First Name is Required")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Pet Last Name is Required")]
        [StringLength(20)]
        public string lastName { get; set; }
       

        [Display(Name = "Prefered Email")]
        [Required(ErrorMessage = "A Valid Email Address is Required")]
        [StringLength(20)]

        public string email { get; set; }
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
        ErrorMessage = "Phone Numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        
        public string phone { get; set; }
        [Display(Name = "Pet Since")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "A Valid Date is Required")]

        public DateTime petSince { get; set; }

     

        public ICollection<Visit> Visit { get; set; }
    }
}