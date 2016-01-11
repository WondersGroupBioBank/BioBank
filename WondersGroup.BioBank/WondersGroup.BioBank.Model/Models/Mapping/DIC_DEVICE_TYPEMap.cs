using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class DIC_DEVICE_TYPEMap : EntityTypeConfiguration<DIC_DEVICE_TYPE>
    {
        public DIC_DEVICE_TYPEMap()
        {
            // Primary Key
            this.HasKey(t => t.SBLXID);

            // Properties
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

            this.Property(t => t.XCKJBHLX)
                .HasMaxLength(2);

            this.Property(t => t.XCKJQSBH)
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
            this.ToTable("DIC_DEVICE_TYPE");
            this.Property(t => t.SBLXID).HasColumnName("SBLXID");
            this.Property(t => t.SBLXDM).HasColumnName("SBLXDM");
            this.Property(t => t.SBLXMC).HasColumnName("SBLXMC");
            this.Property(t => t.SBXH).HasColumnName("SBXH");
            this.Property(t => t.SBCS).HasColumnName("SBCS");
            this.Property(t => t.CS).HasColumnName("CS");
            this.Property(t => t.XCKJBHLX).HasColumnName("XCKJBHLX");
            this.Property(t => t.XCKJQSBH).HasColumnName("XCKJQSBH");
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
