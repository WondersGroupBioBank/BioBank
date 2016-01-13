using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class TB_Role_JLBMap : EntityTypeConfiguration<TB_Role_JLB>
    {
        public TB_Role_JLBMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.JSMC)
                .HasMaxLength(250);

            this.Property(t => t.JSMS)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("TB_Role_JLB");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.JSMC).HasColumnName("JSMC");
            this.Property(t => t.JSMS).HasColumnName("JSMS");
            this.Property(t => t.ZT).HasColumnName("ZT");
            this.Property(t => t.CZRQ).HasColumnName("CZRQ");
            this.Property(t => t.XGRQ).HasColumnName("XGRQ");
            this.Property(t => t.SJLX).HasColumnName("SJLX");
            this.Property(t => t.XXBHLX).HasColumnName("XXBHLX");
        }
    }
}
