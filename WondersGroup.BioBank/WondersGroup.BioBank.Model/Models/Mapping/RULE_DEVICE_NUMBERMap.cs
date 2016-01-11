using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class RULE_DEVICE_NUMBERMap : EntityTypeConfiguration<RULE_DEVICE_NUMBER>
    {
        public RULE_DEVICE_NUMBERMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BHLXDMMC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BH)
                .IsRequired()
                .HasMaxLength(200);

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
            this.ToTable("RULE_DEVICE_NUMBER");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BHLXDM).HasColumnName("BHLXDM");
            this.Property(t => t.BHLXDMMC).HasColumnName("BHLXDMMC");
            this.Property(t => t.BH).HasColumnName("BH");
            this.Property(t => t.XH).HasColumnName("XH");
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
