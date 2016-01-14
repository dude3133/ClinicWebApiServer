using System;
using System.Collections.Generic;

namespace DataAccesLayer.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            this.TreatPlans = new List<TreatPlan>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Clinic_Id { get; set; }
        public virtual Clinic Clinic { get; set; }
        public virtual ICollection<TreatPlan> TreatPlans { get; set; }
    }
}
