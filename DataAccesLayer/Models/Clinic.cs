using System;
using System.Collections.Generic;

namespace DataAccesLayer.Models
{
    public partial class Clinic
    {
        public Clinic()
        {
            this.Doctors = new List<Doctor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
