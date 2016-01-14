using System;
using System.Collections.Generic;

namespace DataAccesLayer.Models
{
    public partial class Medication
    {
        public Medication()
        {
            this.TreatPlans = new List<TreatPlan>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public virtual ICollection<TreatPlan> TreatPlans { get; set; }
    }
}
