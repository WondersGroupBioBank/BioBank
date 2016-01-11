using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_SAMPLE_OPERATION_BASEMap : EntityTypeConfiguration<YBK_SAMPLE_OPERATION_BASE>
    {
        public YBK_SAMPLE_OPERATION_BASEMap()
        {
            // Primary Key
            this.HasKey(t => t.CZLSH);

            // Properties
            this.Property(t => t.CZLSH)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CZLXDM)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.CZLXMC)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CJYXM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ZJCZYXM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SJZT)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CZID)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("YBK_SAMPLE_OPERATION_BASE");
            this.Property(t => t.CZLSH).HasColumnName("CZLSH");
            this.Property(t => t.CZLXDM).HasColumnName("CZLXDM");
            this.Property(t => t.CZLXMC).HasColumnName("CZLXMC");
            this.Property(t => t.CZSJ).HasColumnName("CZSJ");
            this.Property(t => t.CJYID).HasColumnName("CJYID");
            this.Property(t => t.CJYXM).HasColumnName("CJYXM");
            this.Property(t => t.CJSJ).HasColumnName("CJSJ");
            this.Property(t => t.ZJCZYID).HasColumnName("ZJCZYID");
            this.Property(t => t.ZJCZYXM).HasColumnName("ZJCZYXM");
            this.Property(t => t.ZJCZSJ).HasColumnName("ZJCZSJ");
            this.Property(t => t.SJZT).HasColumnName("SJZT");
            this.Property(t => t.CZID).HasColumnName("CZID");
        }
    }
}
