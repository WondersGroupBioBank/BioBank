using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class RULE_DEVICE_TYPESPACE_DEFINE_DETAILSMap : EntityTypeConfiguration<RULE_DEVICE_TYPESPACE_DEFINE_DETAILS>
    {
        public RULE_DEVICE_TYPESPACE_DEFINE_DETAILSMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.XCKJSFZDBH)
                .HasMaxLength(2);

            this.Property(t => t.XCKJBHLX)
                .HasMaxLength(2);

            this.Property(t => t.XCKJQSBH)
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
            this.ToTable("RULE_DEVICE_TYPESPACE_DEFINE_DETAILS");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SBKJDYID).HasColumnName("SBKJDYID");
            this.Property(t => t.BCKJLXID).HasColumnName("BCKJLXID");
            this.Property(t => t.XCKJLXID).HasColumnName("XCKJLXID");
            this.Property(t => t.SBKJGXID).HasColumnName("SBKJGXID");
            this.Property(t => t.XCKJSL).HasColumnName("XCKJSL");
            this.Property(t => t.XCKJSFZDBH).HasColumnName("XCKJSFZDBH");
            this.Property(t => t.XCKJBHLX).HasColumnName("XCKJBHLX");
            this.Property(t => t.XCKJQSBH).HasColumnName("XCKJQSBH");
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
