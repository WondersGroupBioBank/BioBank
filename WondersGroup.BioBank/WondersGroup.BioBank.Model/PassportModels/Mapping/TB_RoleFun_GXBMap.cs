using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class TB_RoleFun_GXBMap : EntityTypeConfiguration<TB_RoleFun_GXB>
    {
        public TB_RoleFun_GXBMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("TB_RoleFun_GXB");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.FunID).HasColumnName("FunID");
            this.Property(t => t.CZRQ).HasColumnName("CZRQ");
        }
    }
}
