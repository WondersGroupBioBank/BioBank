using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_QUESTIONNAIRE_SUBJECTMap : EntityTypeConfiguration<YBK_QUESTIONNAIRE_SUBJECT>
    {
        public YBK_QUESTIONNAIRE_SUBJECTMap()
        {
            // Primary Key
            this.HasKey(t => t.TMID);

            // Properties
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
            this.ToTable("YBK_QUESTIONNAIRE_SUBJECT");
            this.Property(t => t.TMID).HasColumnName("TMID");
            this.Property(t => t.WJID).HasColumnName("WJID");
            this.Property(t => t.SXID).HasColumnName("SXID");
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
