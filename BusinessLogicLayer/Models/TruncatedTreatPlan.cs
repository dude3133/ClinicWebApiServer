using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer.Models
{
    public class TruncatedTreatPlan
    {
        public int Id { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public TruncatedDisease Disease { get; set; }
        public TruncatedDoctor Doctor { get; set; }
        public TruncatedMedication Medication { get; set; }
        public TruncatedPatient Patient { get; set; }
    }
}
