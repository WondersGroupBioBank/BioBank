using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class DIC_SAMPLE_DEALMap : EntityTypeConfiguration<DIC_SAMPLE_DEAL>
    {
        public DIC_SAMPLE_DEALMap()
        {
            // Primary Key
            this.HasKey(t => t.YBCLID);

            // Properties
            this.Property(t => t.YBCLMC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.YBLXDM)
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
            this.ToTable("DIC_SAMPLE_DEAL");
            this.Property(t => t.YBCLID).HasColumnName("YBCLID");
            this.Property(t => t.YBCLMC).HasColumnName("YBCLMC");
            this.Property(t => t.YBLXDM).HasColumnName("YBLXDM");
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
