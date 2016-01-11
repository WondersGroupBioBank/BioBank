using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class RULE_DEVICE_TYPESPACE_DEFINEMap : EntityTypeConfiguration<RULE_DEVICE_TYPESPACE_DEFINE>
    {
        public RULE_DEVICE_TYPESPACE_DEFINEMap()
        {
            // Primary Key
            this.HasKey(t => t.SBKJDYID);

            // Properties
            this.Property(t => t.BCBH)
                .HasMaxLength(200);

            this.Property(t => t.BCBHSY)
                .HasMaxLength(200);

            this.Property(t => t.BCKJIDSY)
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
            this.ToTable("RULE_DEVICE_TYPESPACE_DEFINE");
            this.Property(t => t.SBKJDYID).HasColumnName("SBKJDYID");
            this.Property(t => t.SBKJDYMBID).HasColumnName("SBKJDYMBID");
            this.Property(t => t.KJLXID).HasColumnName("KJLXID");
            this.Property(t => t.CC).HasColumnName("CC");
            this.Property(t => t.BCBH).HasColumnName("BCBH");
            this.Property(t => t.BCBHSY).HasColumnName("BCBHSY");
            this.Property(t => t.BCKJIDSY).HasColumnName("BCKJIDSY");
            this.Property(t => t.KJGID).HasColumnName("KJGID");
            this.Property(t => t.SJSBKJDYID).HasColumnName("SJSBKJDYID");
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
