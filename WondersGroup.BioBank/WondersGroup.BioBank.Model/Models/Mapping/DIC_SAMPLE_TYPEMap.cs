using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class DIC_SAMPLE_TYPEMap : EntityTypeConfiguration<DIC_SAMPLE_TYPE>
    {
        public DIC_SAMPLE_TYPEMap()
        {
            // Primary Key
            this.HasKey(t => t.YBLXDM);

            // Properties
            this.Property(t => t.YBLXDM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.YBLXMC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FDM)
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
            this.ToTable("DIC_SAMPLE_TYPE");
            this.Property(t => t.YBLXDM).HasColumnName("YBLXDM");
            this.Property(t => t.YBLXMC).HasColumnName("YBLXMC");
            this.Property(t => t.CC).HasColumnName("CC");
            this.Property(t => t.FDM).HasColumnName("FDM");
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
