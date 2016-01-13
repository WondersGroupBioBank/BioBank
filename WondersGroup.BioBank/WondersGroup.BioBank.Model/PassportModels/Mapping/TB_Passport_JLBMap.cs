using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class TB_Passport_JLBMap : EntityTypeConfiguration<TB_Passport_JLB>
    {
        public TB_Passport_JLBMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ZH)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MM)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IP)
                .HasMaxLength(20);

            this.Property(t => t.CZRY)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TB_Passport_JLB");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ZH).HasColumnName("ZH");
            this.Property(t => t.MM).HasColumnName("MM");
            this.Property(t => t.ZT).HasColumnName("ZT");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.GQRQ).HasColumnName("GQRQ");
            this.Property(t => t.CZRY).HasColumnName("CZRY");
            this.Property(t => t.CJRQ).HasColumnName("CJRQ");
            this.Property(t => t.XGRQ).HasColumnName("XGRQ");
            this.Property(t => t.LX).HasColumnName("LX");
        }
    }
}
