using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_SAMPLE_PIPE_INFOMap : EntityTypeConfiguration<YBK_SAMPLE_PIPE_INFO>
    {
        public YBK_SAMPLE_PIPE_INFOMap()
        {
            // Primary Key
            this.HasKey(t => t.FGID);

            // Properties
            this.Property(t => t.YBLXDM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.YBLXMC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BZ)
                .HasMaxLength(1000);

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
            this.ToTable("YBK_SAMPLE_PIPE_INFO");
            this.Property(t => t.FGID).HasColumnName("FGID");
            this.Property(t => t.YBSQMXID).HasColumnName("YBSQMXID");
            this.Property(t => t.YBSQID).HasColumnName("YBSQID");
            this.Property(t => t.YBLXDM).HasColumnName("YBLXDM");
            this.Property(t => t.YBLXMC).HasColumnName("YBLXMC");
            this.Property(t => t.GS).HasColumnName("GS");
            this.Property(t => t.BZ).HasColumnName("BZ");
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
