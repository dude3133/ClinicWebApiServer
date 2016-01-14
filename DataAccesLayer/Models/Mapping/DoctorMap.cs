using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccesLayer.Models.Mapping
{
    public class DoctorMap : EntityTypeConfiguration<Doctor>
    {
        public DoctorMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Doctors");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Clinic_Id).HasColumnName("Clinic_Id");

            // Relationships
            this.HasRequired(t => t.Clinic)
                .WithMany(t => t.Doctors)
                .HasForeignKey(d => d.Clinic_Id);

        }
    }
}
