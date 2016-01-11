using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_DEVICE_SPACEUSE_INDEXMap : EntityTypeConfiguration<YBK_DEVICE_SPACEUSE_INDEX>
    {
        public YBK_DEVICE_SPACEUSE_INDEXMap()
        {
            // Primary Key
            this.HasKey(t => t.SBKJSYSYID);

            // Properties
            this.Property(t => t.SFZX)
                .IsRequired()
                .HasMaxLength(2);

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
            this.ToTable("YBK_DEVICE_SPACEUSE_INDEX");
            this.Property(t => t.SBKJSYSYID).HasColumnName("SBKJSYSYID");
            this.Property(t => t.SBID).HasColumnName("SBID");
            this.Property(t => t.SBKJDYMBID).HasColumnName("SBKJDYMBID");
            this.Property(t => t.SFZX).HasColumnName("SFZX");
            this.Property(t => t.SCSJ).HasColumnName("SCSJ");
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
