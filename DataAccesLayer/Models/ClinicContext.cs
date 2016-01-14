using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DataAccesLayer.Models.Mapping;
using System;

namespace DataAccesLayer.Models
{
    public partial class ClinicContext : DbContext, IDisposable
    {
        static ClinicContext()
        {
            Database.SetInitializer<ClinicContext>(null);
        }

        public ClinicContext()
            : base("Name=ClinicContext")
        {
        }

        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<TreatPlan> TreatPlans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClinicMap());
            modelBuilder.Configurations.Add(new DiseaseMap());
            modelBuilder.Configurations.Add(new DoctorMap());
            modelBuilder.Configurations.Add(new MedicationMap());
            modelBuilder.Configurations.Add(new PatientMap());
            modelBuilder.Configurations.Add(new TreatPlanMap());
        }
    }
}
