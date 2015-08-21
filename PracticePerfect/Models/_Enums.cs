using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticePerfect.Models
{

    public enum Title
    {
        [Display(Name = "Mr")]
        Mr,
        [Display(Name = "Miss")]
        Miss,
        [Display(Name = "Mrs")]
        Mrs,
        [Display(Name = "Ms")]
        Ms,
        [Display(Name = "Dr")]
        Dr,
        [Display(Name = "Prof")]
        Prof, 
        Rev, 
        Hon
    }

    public enum Relationship
    {
        Spouse, Family, Friend, Dependant, Account
    }

    public enum MaritalStatus
    {
        Single, Married, Seperated, Divorced, Other
    }

    public enum StressLevel
    {
        Low, Medium, High,
        [Display(Name = "Very High")]
        VeryHigh
    }

    public enum MassagePressure
    {
        Light, Medium, Firm
    }

    public enum LowMedHigh
    {
        Low, Medium, High
    }
}