using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class DIC_SAMPLE_ORGANMap : EntityTypeConfiguration<DIC_SAMPLE_ORGAN>
    {
        public DIC_SAMPLE_ORGANMap()
        {
            // Primary Key
            this.HasKey(t => t.QGDM);

            // Properties
            this.Property(t => t.QGDM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.QGMC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FDM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CJYXM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ZJCZYXM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SJZT)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("DIC_SAMPLE_ORGAN");
            this.Property(t => t.QGDM).HasColumnName("QGDM");
            this.Property(t => t.QGMC).HasColumnName("QGMC");
            this.Property(t => t.CC).HasColumnName("CC");
            this.Property(t => t.FDM).HasColumnName("FDM");
            this.Property(t => t.CJYID).HasColumnName("CJYID");
            this.Property(t => t.CJYXM).HasColumnName("CJYXM");
            this.Property(t => t.CJSJ).HasColumnName("CJSJ");
            this.Property(t => t.ZJCZYID).HasColumnName("ZJCZYID");
            this.Property(t => t.ZJCZYXM).HasColumnName("ZJCZYXM");
            this.Property(t => t.ZJCZSJ).HasColumnName("ZJCZSJ");
            this.Property(t => t.SJZT).HasColumnName("SJZT");
        }
    }
}
