using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticePerfect.Models
{
    public class PatientEmployer
    {
        public int ID { get; set; }
        public int PatientID { get; set; }

        [Display(Name = "Employer")]
        public string Employer { get; set; }
        [Display(Name = "Job title")]
        public string JobTitle { get; set; }
        [Display(Name = "Employed from YYYY/MM/DD")]
        public DateTime EmploymentDate { get; set; }
        [Display(Name = "Company name")]
        public string Companyname { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Telephone number")]
        public string ContactNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
    }
}