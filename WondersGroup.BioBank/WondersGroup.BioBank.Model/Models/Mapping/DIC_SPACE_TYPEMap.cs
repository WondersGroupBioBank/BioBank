using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class DIC_SPACE_TYPEMap : EntityTypeConfiguration<DIC_SPACE_TYPE>
    {
        public DIC_SPACE_TYPEMap()
        {
            // Primary Key
            this.HasKey(t => t.KJLXID);

            // Properties
            this.Property(t => t.KJLX)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.KJLXMC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.TPLJ)
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

            this.Property(t => t.SFJGGD)
                .HasMaxLength(2);

            this.Property(t => t.HBHLX)
                .HasMaxLength(2);

            this.Property(t => t.LBHLX)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("DIC_SPACE_TYPE");
            this.Property(t => t.KJLXID).HasColumnName("KJLXID");
            this.Property(t => t.KJLX).HasColumnName("KJLX");
            this.Property(t => t.KJLXMC).HasColumnName("KJLXMC");
            this.Property(t => t.SCBHS).HasColumnName("SCBHS");
            this.Property(t => t.GGHS).HasColumnName("GGHS");
            this.Property(t => t.GGLS).HasColumnName("GGLS");
            this.Property(t => t.TPLJ).HasColumnName("TPLJ");
            this.Property(t => t.CJYID).HasColumnName("CJYID");
            this.Property(t => t.CJYXM).HasColumnName("CJYXM");
            this.Property(t => t.CJSJ).HasColumnName("CJSJ");
            this.Property(t => t.ZJCZYID).HasColumnName("ZJCZYID");
            this.Property(t => t.ZJCZYXM).HasColumnName("ZJCZYXM");
            this.Property(t => t.ZJCZSJ).HasColumnName("ZJCZSJ");
            this.Property(t => t.SJZT).HasColumnName("SJZT");
            this.Property(t => t.SFJGGD).HasColumnName("SFJGGD");
            this.Property(t => t.HBHLX).HasColumnName("HBHLX");
            this.Property(t => t.LBHLX).HasColumnName("LBHLX");
        }
    }
}
