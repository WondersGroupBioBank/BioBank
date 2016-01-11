using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_SAMPLE_OPERATION_DETAILSMap : EntityTypeConfiguration<YBK_SAMPLE_OPERATION_DETAILS>
    {
        public YBK_SAMPLE_OPERATION_DETAILSMap()
        {
            // Primary Key
            this.HasKey(t => t.CZMXID);

            // Properties
            this.Property(t => t.CZLSH)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.STWYBH)
                .HasMaxLength(200);

            this.Property(t => t.YSBHSY)
                .HasMaxLength(200);

            this.Property(t => t.MBBHSY)
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
            this.ToTable("YBK_SAMPLE_OPERATION_DETAILS");
            this.Property(t => t.CZMXID).HasColumnName("CZMXID");
            this.Property(t => t.CZLSH).HasColumnName("CZLSH");
            this.Property(t => t.KJXXID).HasColumnName("KJXXID");
            this.Property(t => t.STWYBH).HasColumnName("STWYBH");
            this.Property(t => t.KJLXID).HasColumnName("KJLXID");
            this.Property(t => t.YSKJXXID).HasColumnName("YSKJXXID");
            this.Property(t => t.YSBHSY).HasColumnName("YSBHSY");
            this.Property(t => t.MBKJXXID).HasColumnName("MBKJXXID");
            this.Property(t => t.MBBHSY).HasColumnName("MBBHSY");
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
