using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class TB_Module_JLBMap : EntityTypeConfiguration<TB_Module_JLB>
    {
        public TB_Module_JLBMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.MC)
                .HasMaxLength(50);

            this.Property(t => t.LJ)
                .HasMaxLength(50);

            this.Property(t => t.Ext1)
                .HasMaxLength(500);

            this.Property(t => t.Ext2)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("TB_Module_JLB");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MC).HasColumnName("MC");
            this.Property(t => t.PX).HasColumnName("PX");
            this.Property(t => t.CZRQ).HasColumnName("CZRQ");
            this.Property(t => t.XGRQ).HasColumnName("XGRQ");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.LJ).HasColumnName("LJ");
            this.Property(t => t.CC).HasColumnName("CC");
            this.Property(t => t.Ext1).HasColumnName("Ext1");
            this.Property(t => t.Ext2).HasColumnName("Ext2");
        }
    }
}
