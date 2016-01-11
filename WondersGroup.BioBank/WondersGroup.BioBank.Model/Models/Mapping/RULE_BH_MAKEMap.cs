using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class RULE_BH_MAKEMap : EntityTypeConfiguration<RULE_BH_MAKE>
    {
        public RULE_BH_MAKEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BHLX)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.BHMC)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.QZ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DT_ZWF)
                .HasMaxLength(10);

            this.Property(t => t.DT_Z)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("RULE_BH_MAKE");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BHLX).HasColumnName("BHLX");
            this.Property(t => t.BHMC).HasColumnName("BHMC");
            this.Property(t => t.QZ).HasColumnName("QZ");
            this.Property(t => t.QSZ).HasColumnName("QSZ");
            this.Property(t => t.DQZ).HasColumnName("DQZ");
            this.Property(t => t.KDZ).HasColumnName("KDZ");
            this.Property(t => t.CD).HasColumnName("CD");
            this.Property(t => t.DT_ZWF).HasColumnName("DT_ZWF");
            this.Property(t => t.DT_Z).HasColumnName("DT_Z");
            this.Property(t => t.DT_SFCZDQZ).HasColumnName("DT_SFCZDQZ");
        }
    }
}
