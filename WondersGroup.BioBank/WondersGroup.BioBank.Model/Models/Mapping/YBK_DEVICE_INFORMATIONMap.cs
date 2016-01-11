using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_DEVICE_INFORMATIONMap : EntityTypeConfiguration<YBK_DEVICE_INFORMATION>
    {
        public YBK_DEVICE_INFORMATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.SBID);

            // Properties
            this.Property(t => t.SBBH)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.SBMC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.SBLXDM)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.SBLXMC)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SBXH)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.SBCS)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.SBWZ)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.QYZT)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.SSKSMC)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.CJYXM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ZJCZYXM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.SJZT)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("YBK_DEVICE_INFORMATION");
            this.Property(t => t.SBID).HasColumnName("SBID");
            this.Property(t => t.SBBH).HasColumnName("SBBH");
            this.Property(t => t.SBMC).HasColumnName("SBMC");
            this.Property(t => t.SBLXID).HasColumnName("SBLXID");
            this.Property(t => t.SBLXDM).HasColumnName("SBLXDM");
            this.Property(t => t.SBLXMC).HasColumnName("SBLXMC");
            this.Property(t => t.SBXH).HasColumnName("SBXH");
            this.Property(t => t.SBCS).HasColumnName("SBCS");
            this.Property(t => t.SBWZ).HasColumnName("SBWZ");
            this.Property(t => t.QYZT).HasColumnName("QYZT");
            this.Property(t => t.SSKS).HasColumnName("SSKS");
            this.Property(t => t.SSKSMC).HasColumnName("SSKSMC");
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
