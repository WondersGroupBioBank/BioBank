using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_PROJECT_INFORMATION_CDMap : EntityTypeConfiguration<YBK_PROJECT_INFORMATION_CD>
    {
        public YBK_PROJECT_INFORMATION_CDMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.YBLCZD)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.YBLCZDMC)
                .IsRequired()
                .HasMaxLength(100);

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
            this.ToTable("YBK_PROJECT_INFORMATION_CD");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.XMID).HasColumnName("XMID");
            this.Property(t => t.YBLCZD).HasColumnName("YBLCZD");
            this.Property(t => t.YBLCZDMC).HasColumnName("YBLCZDMC");
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
