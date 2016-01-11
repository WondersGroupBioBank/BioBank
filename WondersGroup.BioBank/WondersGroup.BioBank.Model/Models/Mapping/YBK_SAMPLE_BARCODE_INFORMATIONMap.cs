using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_SAMPLE_BARCODE_INFORMATIONMap : EntityTypeConfiguration<YBK_SAMPLE_BARCODE_INFORMATION>
    {
        public YBK_SAMPLE_BARCODE_INFORMATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.TMID);

            // Properties
            this.Property(t => t.TMID)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.YBLXDM)
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
            this.ToTable("YBK_SAMPLE_BARCODE_INFORMATION");
            this.Property(t => t.TMID).HasColumnName("TMID");
            this.Property(t => t.YBLXDM).HasColumnName("YBLXDM");
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
