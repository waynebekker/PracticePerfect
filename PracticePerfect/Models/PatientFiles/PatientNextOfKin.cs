using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticePerfect.Models
{
    public class PatientNextOfKin
    {
        public int ID { get; set; }
        public int PatientID { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Relationship")]
        [UIHint("Enum-radio")]
        public Relationship? Relationship { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }
    }
}