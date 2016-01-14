using System;
using System.Collections.Generic;

namespace DataAccesLayer.Models
{
    public partial class Patient
    {
        public Patient()
        {
            this.TreatPlans = new List<TreatPlan>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Hometown { get; set; }
        public DateTime? Birthdate { get; set; }
        public virtual ICollection<TreatPlan> TreatPlans { get; set; }
    }
}
