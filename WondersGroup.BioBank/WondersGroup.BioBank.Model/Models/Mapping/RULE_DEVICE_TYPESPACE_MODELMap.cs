using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class RULE_DEVICE_TYPESPACE_MODELMap : EntityTypeConfiguration<RULE_DEVICE_TYPESPACE_MODEL>
    {
        public RULE_DEVICE_TYPESPACE_MODELMap()
        {
            // Primary Key
            this.HasKey(t => t.SBKJDYMBID);

            // Properties
            this.Property(t => t.SBKJDYMBMC)
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
            this.ToTable("RULE_DEVICE_TYPESPACE_MODEL");
            this.Property(t => t.SBKJDYMBID).HasColumnName("SBKJDYMBID");
            this.Property(t => t.SBKJDYMBMC).HasColumnName("SBKJDYMBMC");
            this.Property(t => t.SBLXID).HasColumnName("SBLXID");
            this.Property(t => t.SCSJ).HasColumnName("SCSJ");
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
