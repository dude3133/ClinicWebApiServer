using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccesLayer.Models.Mapping
{
    public class MedicationMap : EntityTypeConfiguration<Medication>
    {
        public MedicationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Manufacturer)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Medications");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Manufacturer).HasColumnName("Manufacturer");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
