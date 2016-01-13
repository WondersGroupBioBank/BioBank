using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class TB_ModuleFun_JLBMap : EntityTypeConfiguration<TB_ModuleFun_JLB>
    {
        public TB_ModuleFun_JLBMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.FunMC)
                .HasMaxLength(50);

            this.Property(t => t.FunDM)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TB_ModuleFun_JLB");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ModuleID).HasColumnName("ModuleID");
            this.Property(t => t.FunMC).HasColumnName("FunMC");
            this.Property(t => t.FunDM).HasColumnName("FunDM");
            this.Property(t => t.PX).HasColumnName("PX");
            this.Property(t => t.CZRQ).HasColumnName("CZRQ");
            this.Property(t => t.XGRQ).HasColumnName("XGRQ");

            // Relationships
            this.HasOptional(t => t.TB_Module_JLB)
                .WithMany(t => t.TB_ModuleFun_JLB)
                .HasForeignKey(d => d.ModuleID);

        }
    }
}
