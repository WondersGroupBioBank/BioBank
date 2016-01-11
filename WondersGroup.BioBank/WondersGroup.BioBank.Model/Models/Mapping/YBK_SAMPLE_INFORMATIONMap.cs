using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_SAMPLE_INFORMATIONMap : EntityTypeConfiguration<YBK_SAMPLE_INFORMATION>
    {
        public YBK_SAMPLE_INFORMATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.YBID);

            // Properties
            this.Property(t => t.YBLXDM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.YBLXMC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.TMID)
                .HasMaxLength(200);

            this.Property(t => t.YBZT)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.YBZTMC)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CJYXM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ZJCZYXM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.SJZT)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.BZ)
                .HasMaxLength(2000);

            this.Property(t => t.SYZT)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("YBK_SAMPLE_INFORMATION");
            this.Property(t => t.YBID).HasColumnName("YBID");
            this.Property(t => t.YBLXDM).HasColumnName("YBLXDM");
            this.Property(t => t.YBLXMC).HasColumnName("YBLXMC");
            this.Property(t => t.YBSQMXID).HasColumnName("YBSQMXID");
            this.Property(t => t.YBSQID).HasColumnName("YBSQID");
            this.Property(t => t.CAIJSJ).HasColumnName("CAIJSJ");
            this.Property(t => t.FGID).HasColumnName("FGID");
            this.Property(t => t.TMID).HasColumnName("TMID");
            this.Property(t => t.DQWZID).HasColumnName("DQWZID");
            this.Property(t => t.FYBID).HasColumnName("FYBID");
            this.Property(t => t.YBZT).HasColumnName("YBZT");
            this.Property(t => t.YBZTMC).HasColumnName("YBZTMC");
            this.Property(t => t.CJYID).HasColumnName("CJYID");
            this.Property(t => t.CJYXM).HasColumnName("CJYXM");
            this.Property(t => t.CJSJ).HasColumnName("CJSJ");
            this.Property(t => t.ZJCZYID).HasColumnName("ZJCZYID");
            this.Property(t => t.ZJCZYXM).HasColumnName("ZJCZYXM");
            this.Property(t => t.ZJCZSJ).HasColumnName("ZJCZSJ");
            this.Property(t => t.SJZT).HasColumnName("SJZT");
            this.Property(t => t.LLZT).HasColumnName("LLZT");
            this.Property(t => t.YBTJ).HasColumnName("YBTJ");
            this.Property(t => t.DRCS).HasColumnName("DRCS");
            this.Property(t => t.BZ).HasColumnName("BZ");
            this.Property(t => t.SYZT).HasColumnName("SYZT");
        }
    }
}
