using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticePerfect.Models
{
    public class PatientQuestionaire
    {

        public int ID { get; set; }
        public int PatientID { get; set; }

        public bool Asthma { get; set; }
        public bool Allergies { get; set; }
        public bool Anemia { get; set; }
        public bool Arthritis { get; set; }
        public bool Smoker { get; set; } // bool = yes or no

        [Display(Name = "Cigarettes per day")]
        public int SmokeHowManyaDay { get; set; } //int = number without decimals ie 0, 34, 2 etc
        [Display(Name = "Any Previous Diseases")]
        public string PreviousDiseases { get; set; } // string = plain text ie cancer, boob ouch etc
        [Display(Name = "Any previous operations")]
        public bool PerviousOperations { get; set; }
        [Display(Name = "If yes, provide details")]
        public string PerviousOperationsDetails { get; set; } // text = the details type in

    }
}