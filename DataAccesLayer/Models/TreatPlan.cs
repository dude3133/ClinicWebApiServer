using System;
using System.Collections.Generic;

namespace DataAccesLayer.Models
{
    public partial class TreatPlan
    {
        public int Id { get; set; }
        public int Patient_Id { get; set; }
        public int Medication_Id { get; set; }
        public int Disease_Id { get; set; }
        public int Doctor_Id { get; set; }
        public System.DateTime Begin { get; set; }
        public System.DateTime End { get; set; }
        public virtual Disease Disease { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Medication Medication { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
