using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HW04.Models
{
    public class User
    {
        
       public int UserID { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage ="You must provide a name")]
        public string Name { get; set; }
        
        [Display(Name="Number Of Tickets")]
        [Range(1, 100, ErrorMessage = "Enter Valid User ID")]
        public int NumOfTickets { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name="Date")]
        public DateTime rDate { get; set; }
    }
}