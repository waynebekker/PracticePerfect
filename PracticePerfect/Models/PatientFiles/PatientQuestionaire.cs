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

        [Display(Name = "Within the last year, have you been under a physician’s care?")]
        public bool PhysiciansCare { get; set; }
        [Display(Name = "If so provide details")]
        public string PhysiciansCareDetails { get; set; }

        [Display(Name = "Within the last 9 months have you undergone any surgery?")]
        public bool RecentSurgery { get; set; }
        [Display(Name = "If so provide details")]
        public string RecentSurgeryDetails { get; set; }

        [Display(Name = "Do you have any medical implants e.g. pacemaker, plates, screws?")]
        public bool Medicalimplants { get; set; }
        [Display(Name = "If so provide details")]
        public string MedicalimplantsDetails { get; set; }

        [Display(Name = "Have you any injury over the last 5 years?")]
        public bool Recentinjury { get; set; }
        [Display(Name = "If so provide details")]
        public string RecentinjuryDetails { get; set; }

        [Display(Name = "Are you currently on any medications, supplements, vitamins, diuretics, slimming tablets etc.??")]
        public bool Recentmedication { get; set; }
        [Display(Name = "If so provide details")]
        public string RecentmedicationDetails { get; set; }

        [Display(Name = "Do you smoke?")]
        public bool Smoke { get; set; }
        [Display(Name = "How many per day")]
        public string Howmanyperday { get; set; }

        [Display(Name = "Do you consume alcholo")]
        public bool Alcholocosumsion { get; set; }
        [Display(Name = "How often do you consume alcohol")]
        public string Howoften { get; set; }

        [Display(Name = "Do you follow a restricted diet")]
        public bool Restricteddiet { get; set; }
        [Display(Name = "If yes provide details")]
        public string Testricteddietdetails { get; set; }

        [Display(Name = "Do you wear contact lenses?")]
        public bool Contactlenses { get; set; }
       
        [Display(Name = "Do you exercise regularly")]
        public bool Exerciseregularly { get; set; }
        [Display(Name = "If yes provide details")]
        public string Exerciserregularlydetails { get; set; } 

        [Display(Name = "Do you have any difficulty laying on your back, side or stomach?")]
        public bool Difficultylayingdown { get; set; }
        [Display(Name = "If yes provide details")]
        public string Difficultylayingdowndetails { get; set; }

        [Display(Name = "Have you had a proffessional massage before?")]
        public bool Resentmassage { get; set; }
        
        [Display(Name = "Please rate your stress level")]        
        [UIHint("Enum-radio")]
        public StressLevel? StressLevel { get; set; }

        [Display(Name = "Abscess or open sores")]
        public bool Abscessoropensores { get; set; }

        [Display(Name = "Allergies")]
        public bool Allergies { get; set; }

        [Display(Name = "Anaemia")]
        public bool Anaemia { get; set; }

        [Display(Name = "Arthritis")]
        public bool Arthritis { get; set; }

        [Display(Name = "Asthma")]
        public bool Asthma { get; set; }

        [Display(Name = "Cancer")]
        public bool  Cancer { get; set; }

        [Display(Name = "Chronic pain")]
        public bool Chronicpain { get; set; }

        [Display(Name = "Coagulation or clotting")]
        public bool Coagulationorclotting { get; set; }

        [Display(Name = "Bruising / Swelling")]
        public bool BruisingSwelling { get; set; }

        [Display(Name = "Diabetes")]
        public bool  Diabetes { get; set; }

        [Display(Name = "Epilepsy")]
        public bool  Epilepsy { get; set; }

        [Display(Name = "Fatigue")]
        public bool  Fatigue { get; set; }

        [Display(Name = "Fever")]
        public bool  Fever { get; set; }

        [Display(Name = "Headaches / Migraines")]
        public bool  HeadachesMigraines { get; set; }

        [Display(Name = "Heart condition")]
        public bool  Heartcondition { get; set; }

        [Display(Name = "High/low blood pressure")]
        public bool  Highlowbloodpressure { get; set; }

        [Display(Name = "Hormonal imbalance")]
        public bool  Hormonalimbalance { get; set; }

        [Display(Name = "Osteoporosis/back condition")]
        public bool  Osteoporosisbackcondition { get; set; }

        [Display(Name = "Pinched nerve")]
        public bool  Pinchednerve { get; set; }

        [Display(Name = "Poor Circulation")]
        public bool PoorCirculation { get; set; }

        [Display(Name = "Skin Irritation/sensitivity")]
        public bool SkinIrritationsensitivity { get; set; }

        [Display(Name = "Thyroid condition")]
        public bool Thyroidcondition { get; set; }

        [Display(Name = "Varicose veins")]
        public bool  Varicoseveins { get; set; }

        [Display(Name = "Do you have any allergic reactions to oils, lotions, ointments or any other substances put on your skin??")]
        public bool Essentialallergis { get; set; }
        [Display(Name = "If so provide details")]
        public string EssentialallergisDetails { get; set; }

        [Display(Name = "Is there a particular area of the body where you are experiencing tension, stiffness or other discomfort?")]
        public bool Particulararea { get; set; }
        [Display(Name = "If so provide details")]
        public string ParticulareaeDetails { get; set; }

        [Display(Name = "What tyo of massage pressure do you prefer?")]        
        [UIHint("Enum-radio")]
        public MassagePressure? MassagePressure { get; set; }

        [Display(Name = "what is your pain threshold?")]        
        [UIHint("Enum-radio")]
        public LowMedHigh? Painthreshold { get; set; }

        [Display(Name = "Do you dirnk more than 4 caffinated beverages dail")]
        public bool  Caffinatedbeverages{ get; set; }
        
        [Display(Name = "Ary you taking any form of contreception")]
        public bool  Contreception { get; set; }
        
        [Display(Name = "Are you currently having or due for you menstrual cycle?")]
        public bool  Menstrualcycle{ get; set; }
             
        [Display(Name = "Are you pregnant or trying to become pregnant?")]
        public bool  Precnant { get; set; }
        [Display(Name = "If yes How many weeks?")]
        public string  Howmanyweeks { get; set; }

 



    }
}