using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class DIC_PRACTITIONERMap : EntityTypeConfiguration<DIC_PRACTITIONER>
    {
        public DIC_PRACTITIONERMap()
        {
            // Primary Key
            this.HasKey(t => t.YSID);

            // Properties
            this.Property(t => t.GH)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.XM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.SFZH)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.SSKSMC)
                .HasMaxLength(64);

            this.Property(t => t.ZWDM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ZWMC)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ZCDM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ZCMC)
                .HasMaxLength(32);

            this.Property(t => t.CSRQ)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.RYLB)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.CJYXM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ZJCZYXM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SJZT)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PYM)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DIC_PRACTITIONER");
            this.Property(t => t.YSID).HasColumnName("YSID");
            this.Property(t => t.GH).HasColumnName("GH");
            this.Property(t => t.XM).HasColumnName("XM");
            this.Property(t => t.SFZH).HasColumnName("SFZH");
            this.Property(t => t.SSKS).HasColumnName("SSKS");
            this.Property(t => t.SSKSMC).HasColumnName("SSKSMC");
            this.Property(t => t.ZWDM).HasColumnName("ZWDM");
            this.Property(t => t.ZWMC).HasColumnName("ZWMC");
            this.Property(t => t.ZCDM).HasColumnName("ZCDM");
            this.Property(t => t.ZCMC).HasColumnName("ZCMC");
            this.Property(t => t.CSRQ).HasColumnName("CSRQ");
            this.Property(t => t.RYLB).HasColumnName("RYLB");
            this.Property(t => t.CJYID).HasColumnName("CJYID");
            this.Property(t => t.CJYXM).HasColumnName("CJYXM");
            this.Property(t => t.CJSJ).HasColumnName("CJSJ");
            this.Property(t => t.ZJCZYID).HasColumnName("ZJCZYID");
            this.Property(t => t.ZJCZYXM).HasColumnName("ZJCZYXM");
            this.Property(t => t.ZJCZSJ).HasColumnName("ZJCZSJ");
            this.Property(t => t.SJZT).HasColumnName("SJZT");
            this.Property(t => t.PYM).HasColumnName("PYM");
        }
    }
}
