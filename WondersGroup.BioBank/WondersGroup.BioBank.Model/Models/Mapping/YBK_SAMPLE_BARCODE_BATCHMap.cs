using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_SAMPLE_BARCODE_BATCHMap : EntityTypeConfiguration<YBK_SAMPLE_BARCODE_BATCH>
    {
        public YBK_SAMPLE_BARCODE_BATCHMap()
        {
            // Primary Key
            this.HasKey(t => t.PCH);

            // Properties
            this.Property(t => t.PCH)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.YBLXDM)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.QSTMID)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.JZTMID)
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
            this.ToTable("YBK_SAMPLE_BARCODE_BATCH");
            this.Property(t => t.PCH).HasColumnName("PCH");
            this.Property(t => t.YBLXDM).HasColumnName("YBLXDM");
            this.Property(t => t.JLSJ).HasColumnName("JLSJ");
            this.Property(t => t.QSTMID).HasColumnName("QSTMID");
            this.Property(t => t.JZTMID).HasColumnName("JZTMID");
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
