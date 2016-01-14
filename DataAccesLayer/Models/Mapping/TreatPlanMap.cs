using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccesLayer.Models.Mapping
{
    public class TreatPlanMap : EntityTypeConfiguration<TreatPlan>
    {
        public TreatPlanMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("TreatPlans");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Patient_Id).HasColumnName("Patient_Id");
            this.Property(t => t.Medication_Id).HasColumnName("Medication_Id");
            this.Property(t => t.Disease_Id).HasColumnName("Disease_Id");
            this.Property(t => t.Doctor_Id).HasColumnName("Doctor_Id");
            this.Property(t => t.Begin).HasColumnName("Begin");
            this.Property(t => t.End).HasColumnName("End");

            // Relationships
            this.HasRequired(t => t.Disease)
                .WithMany(t => t.TreatPlans)
                .HasForeignKey(d => d.Disease_Id);
            this.HasRequired(t => t.Doctor)
                .WithMany(t => t.TreatPlans)
                .HasForeignKey(d => d.Doctor_Id);
            this.HasRequired(t => t.Medication)
                .WithMany(t => t.TreatPlans)
                .HasForeignKey(d => d.Medication_Id);
            this.HasRequired(t => t.Patient)
                .WithMany(t => t.TreatPlans)
                .HasForeignKey(d => d.Patient_Id);

        }
    }
}
