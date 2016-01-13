using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class TB_PassportRole_GXBMap : EntityTypeConfiguration<TB_PassportRole_GXB>
    {
        public TB_PassportRole_GXBMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("TB_PassportRole_GXB");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PassportID).HasColumnName("PassportID");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.CZRQ).HasColumnName("CZRQ");
        }
    }
}
