using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class V_PassportListMap : EntityTypeConfiguration<V_PassportList>
    {
        public V_PassportListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.ZH, t.XM, t.XB, t.SYKSMC, t.JSID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ZH)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.XM)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.XB)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ZC)
                .HasMaxLength(50);

            this.Property(t => t.SYKS)
                .HasMaxLength(50);

            this.Property(t => t.SYKSMC)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.LXDH)
                .HasMaxLength(50);

            this.Property(t => t.YX)
                .HasMaxLength(50);

            this.Property(t => t.JSMC)
                .HasMaxLength(250);

            this.Property(t => t.JSID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GH)
                .HasMaxLength(50);

            this.Property(t => t.SFZH)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("V_PassportList");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ZH).HasColumnName("ZH");
            this.Property(t => t.ZT).HasColumnName("ZT");
            this.Property(t => t.XM).HasColumnName("XM");
            this.Property(t => t.XB).HasColumnName("XB");
            this.Property(t => t.ZC).HasColumnName("ZC");
            this.Property(t => t.SYKS).HasColumnName("SYKS");
            this.Property(t => t.SYKSMC).HasColumnName("SYKSMC");
            this.Property(t => t.LXDH).HasColumnName("LXDH");
            this.Property(t => t.YX).HasColumnName("YX");
            this.Property(t => t.CJRQ).HasColumnName("CJRQ");
            this.Property(t => t.JSMC).HasColumnName("JSMC");
            this.Property(t => t.JSID).HasColumnName("JSID");
            this.Property(t => t.GH).HasColumnName("GH");
            this.Property(t => t.SFZH).HasColumnName("SFZH");
        }
    }
}
