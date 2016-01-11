using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class RULE_DEVICE_TPYESPACE_RELATIONMap : EntityTypeConfiguration<RULE_DEVICE_TPYESPACE_RELATION>
    {
        public RULE_DEVICE_TPYESPACE_RELATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.SBKJGXID);

            // Properties
            this.Property(t => t.XCKJBHLX)
                .HasMaxLength(2);

            this.Property(t => t.XCKJQSBH)
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

            this.Property(t => t.XCBHFX)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("RULE_DEVICE_TPYESPACE_RELATION");
            this.Property(t => t.SBKJGXID).HasColumnName("SBKJGXID");
            this.Property(t => t.SBLXID).HasColumnName("SBLXID");
            this.Property(t => t.BCKJLXID).HasColumnName("BCKJLXID");
            this.Property(t => t.XCKJLXID).HasColumnName("XCKJLXID");
            this.Property(t => t.BHSL).HasColumnName("BHSL");
            this.Property(t => t.XCKJBHLX).HasColumnName("XCKJBHLX");
            this.Property(t => t.XCKJQSBH).HasColumnName("XCKJQSBH");
            this.Property(t => t.CJYID).HasColumnName("CJYID");
            this.Property(t => t.CJYXM).HasColumnName("CJYXM");
            this.Property(t => t.CJSJ).HasColumnName("CJSJ");
            this.Property(t => t.ZJCZYID).HasColumnName("ZJCZYID");
            this.Property(t => t.ZJCZYXM).HasColumnName("ZJCZYXM");
            this.Property(t => t.ZJCZSJ).HasColumnName("ZJCZSJ");
            this.Property(t => t.SJZT).HasColumnName("SJZT");
            this.Property(t => t.XCBHFX).HasColumnName("XCBHFX");
        }
    }
}
