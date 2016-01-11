using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_DEVICE_INFORMATION_PICTUREMap : EntityTypeConfiguration<YBK_DEVICE_INFORMATION_PICTURE>
    {
        public YBK_DEVICE_INFORMATION_PICTUREMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.TPDZ)
                .IsRequired()
                .HasMaxLength(200);

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
            this.ToTable("YBK_DEVICE_INFORMATION_PICTURE");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SBID).HasColumnName("SBID");
            this.Property(t => t.TPDZ).HasColumnName("TPDZ");
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
