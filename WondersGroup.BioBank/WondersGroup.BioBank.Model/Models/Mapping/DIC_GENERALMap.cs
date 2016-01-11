using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class DIC_GENERALMap : EntityTypeConfiguration<DIC_GENERAL>
    {
        public DIC_GENERALMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ZYDM)
                .HasMaxLength(255);

            this.Property(t => t.ZYDMMC)
                .HasMaxLength(255);

            this.Property(t => t.Z)
                .HasMaxLength(255);

            this.Property(t => t.ZHY)
                .HasMaxLength(255);

            this.Property(t => t.LB)
                .HasMaxLength(255);

            this.Property(t => t.SM)
                .HasMaxLength(255);

            this.Property(t => t.SJZT)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("DIC_GENERAL");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ZYDM).HasColumnName("ZYDM");
            this.Property(t => t.ZYDMMC).HasColumnName("ZYDMMC");
            this.Property(t => t.Z).HasColumnName("Z");
            this.Property(t => t.ZHY).HasColumnName("ZHY");
            this.Property(t => t.LB).HasColumnName("LB");
            this.Property(t => t.SM).HasColumnName("SM");
            this.Property(t => t.SJZT).HasColumnName("SJZT");
        }
    }
}
