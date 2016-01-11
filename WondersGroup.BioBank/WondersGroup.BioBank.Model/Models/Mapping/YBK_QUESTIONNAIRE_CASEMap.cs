using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_QUESTIONNAIRE_CASEMap : EntityTypeConfiguration<YBK_QUESTIONNAIRE_CASE>
    {
        public YBK_QUESTIONNAIRE_CASEMap()
        {
            // Primary Key
            this.HasKey(t => t.SLID);

            // Properties
            this.Property(t => t.WJMC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.SSXMMC)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.HZID)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.HZXM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ZD)
                .HasMaxLength(500);

            this.Property(t => t.ZDRGH)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ZDRXM)
                .IsRequired()
                .HasMaxLength(32);

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
            this.ToTable("YBK_QUESTIONNAIRE_CASE");
            this.Property(t => t.SLID).HasColumnName("SLID");
            this.Property(t => t.WJID).HasColumnName("WJID");
            this.Property(t => t.WJMC).HasColumnName("WJMC");
            this.Property(t => t.SSXM).HasColumnName("SSXM");
            this.Property(t => t.SSXMMC).HasColumnName("SSXMMC");
            this.Property(t => t.HZID).HasColumnName("HZID");
            this.Property(t => t.HZXM).HasColumnName("HZXM");
            this.Property(t => t.ZD).HasColumnName("ZD");
            this.Property(t => t.ZDRID).HasColumnName("ZDRID");
            this.Property(t => t.ZDRGH).HasColumnName("ZDRGH");
            this.Property(t => t.ZDRXM).HasColumnName("ZDRXM");
            this.Property(t => t.ZDSJ).HasColumnName("ZDSJ");
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
