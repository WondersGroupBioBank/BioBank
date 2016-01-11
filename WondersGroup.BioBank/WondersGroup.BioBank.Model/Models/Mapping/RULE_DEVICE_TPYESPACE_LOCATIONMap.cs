using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class RULE_DEVICE_TPYESPACE_LOCATIONMap : EntityTypeConfiguration<RULE_DEVICE_TPYESPACE_LOCATION>
    {
        public RULE_DEVICE_TPYESPACE_LOCATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.SBKJWZID);

            // Properties
            this.Property(t => t.HH)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LH)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.BH)
                .IsRequired()
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

            // Table & Column Mappings
            this.ToTable("RULE_DEVICE_TPYESPACE_LOCATION");
            this.Property(t => t.SBKJWZID).HasColumnName("SBKJWZID");
            this.Property(t => t.KJLXID).HasColumnName("KJLXID");
            this.Property(t => t.HH).HasColumnName("HH");
            this.Property(t => t.LH).HasColumnName("LH");
            this.Property(t => t.BH).HasColumnName("BH");
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
