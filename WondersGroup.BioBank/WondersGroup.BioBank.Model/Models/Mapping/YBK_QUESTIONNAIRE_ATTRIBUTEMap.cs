using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_QUESTIONNAIRE_ATTRIBUTEMap : EntityTypeConfiguration<YBK_QUESTIONNAIRE_ATTRIBUTE>
    {
        public YBK_QUESTIONNAIRE_ATTRIBUTEMap()
        {
            // Primary Key
            this.HasKey(t => t.SXID);

            // Properties
            this.Property(t => t.SXMC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.SXLX)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.SXLXMC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.SXMS)
                .HasMaxLength(1000);

            this.Property(t => t.ZLX)
                .HasMaxLength(5);

            this.Property(t => t.ZLXMC)
                .HasMaxLength(200);

            this.Property(t => t.SXLY)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.SXLYMC)
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
            this.ToTable("YBK_QUESTIONNAIRE_ATTRIBUTE");
            this.Property(t => t.SXID).HasColumnName("SXID");
            this.Property(t => t.SXMC).HasColumnName("SXMC");
            this.Property(t => t.SXLX).HasColumnName("SXLX");
            this.Property(t => t.SXLXMC).HasColumnName("SXLXMC");
            this.Property(t => t.SXMS).HasColumnName("SXMS");
            this.Property(t => t.ZLX).HasColumnName("ZLX");
            this.Property(t => t.ZLXMC).HasColumnName("ZLXMC");
            this.Property(t => t.ZCD).HasColumnName("ZCD");
            this.Property(t => t.ZJD).HasColumnName("ZJD");
            this.Property(t => t.ZDZ).HasColumnName("ZDZ");
            this.Property(t => t.ZXZ).HasColumnName("ZXZ");
            this.Property(t => t.SXLY).HasColumnName("SXLY");
            this.Property(t => t.SXLYMC).HasColumnName("SXLYMC");
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
