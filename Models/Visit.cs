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
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description of Visit is Needed")]
        [StringLength(50)]
       public string description { get; set; }
        [Display(Name = "Visit Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]

        public string visitDate { get; set; }
       



        public virtual Pets Pets { get; set; }

    }
}