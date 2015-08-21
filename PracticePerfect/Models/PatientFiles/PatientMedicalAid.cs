using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticePerfect.Models
{
    public class PatientMedicalAid
    {
        //patient medical aid

        public int ID { get; set; }
        public int PatientID { get; set; }
        [Display(Name = "Medical Aid")]
        [UIHint("Enum-radio")]
        public bool MedadYN { get; set; }
        [Display(Name = "Medical aid name")]
        public string MedaidName { get; set; }
        [Display(Name = "Plan")]
        public string MedaidPlan { get; set; }
        [Display(Name = "Member number")]
        public string MedaidMemberNumber { get; set; }
        [Display(Name = "Patient is main member")]
        [UIHint("Enum-radio")]
        public bool MedadiIsMainMember { get; set; }
        [Display(Name = "Dependant Code")]
        public string MedAidDependantCode { get; set; }

    }
}