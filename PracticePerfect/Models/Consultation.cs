using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticePerfect.Models
{
    public class Consultation
    {
        public int ID { get; set; }
        public int PatientID { get; set; }
        public DateTime ConsultationDate { get; set; }
        public string Symptoms { get; set; }
        public string Notes { get; set; }
        public string Diagnosis { get; set; }
        public string DiagnosisCode { get; set; }
        public string MedicationPrescribed { get; set; }
        public string MedicationDispensed { get; set; }
        public int Fees { get; set; }
        public bool Paid { get; set; }
        public string PaymentMethod { get; set; }

    }
}