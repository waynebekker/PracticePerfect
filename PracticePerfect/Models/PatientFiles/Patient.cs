using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticePerfect.Models
{

    public class Patient
    {
        public int ID { get; set; }

        [Display(Name = "File Number")]
        [StringLength(10, ErrorMessage = "File number cannot be longer than 10 characters.")]
        public string FileNumber { get; set; }

        [DataType(DataType.Password)]
        public string Secret { get; set; }

        public string Reminder { get; set; }

        [UIHint("Enum-radio")]
        public Title? Title { get; set; }

        [Required, StringLength(50, ErrorMessage = "Firstname cannot be longer than 50 characters."), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, StringLength(100, ErrorMessage = "Surname cannot be longer than 100 characters."), Display(Name = "Surname")]
        public string Surname { get; set; }

        [StringLength(20, ErrorMessage = "ID number cannot be longer than 20 characters.")]
        [Display(Name = "ID or Passport Number")]
        public string IdNumber { get; set; }

        [Display(Name = "Date of birth YYYY/MM/DD")]
        public DateTime BirthDate { get; set; }

        //contact
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Display(Name = "Telephone number")]
        public string ContactNumber { get; set; }
        [Display(Name = "Cellphone number")]
        public string CellNumber { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        [StringLength(4, ErrorMessage = "Post code cannot be longer than 4 characters.")]
        [Display(Name = "Code")]
        public string Address4 { get; set; }



        //Financial
        [Display(Name = "Consultation fee")]
        public float ConsultationFee { get; set; }
        [Display(Name = "Account balance")]
        public float CurrentBalance { get; set; }

        //Linked stuff
        //Details
        public virtual ICollection<PatientNextOfKin> NextOfKin { get; set; }
        public virtual ICollection<PatientEmployer> Employers { get; set; }
        public virtual ICollection<PatientMedicalAid> MedicalAids { get; set; }

        //Visits
        public virtual ICollection<Consultation> Consultations { get; set; }

        //Medication given

        //Scripts

        //Sicknotes

        //Referrals

        //LabTests

    }
}