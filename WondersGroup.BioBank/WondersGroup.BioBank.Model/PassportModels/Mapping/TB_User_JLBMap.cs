using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class TB_User_JLBMap : EntityTypeConfiguration<TB_User_JLB>
    {
        public TB_User_JLBMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.XM, t.XB, t.PassPortID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.XM)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.XB)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ZC)
                .HasMaxLength(50);

            this.Property(t => t.SYKS)
                .HasMaxLength(50);

            this.Property(t => t.LXDH)
                .HasMaxLength(50);

            this.Property(t => t.YX)
                .HasMaxLength(50);

            this.Property(t => t.IP)
                .HasMaxLength(250);

            this.Property(t => t.REMARK)
                .HasMaxLength(250);

            this.Property(t => t.PassPortID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CZYGH)
                .HasMaxLength(18);

            this.Property(t => t.CZYXM)
                .HasMaxLength(64);

            this.Property(t => t.SYKSMC)
                .HasMaxLength(50);

            this.Property(t => t.GH)
                .HasMaxLength(50);

            this.Property(t => t.SFZH)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TB_User_JLB");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.XM).HasColumnName("XM");
            this.Property(t => t.XB).HasColumnName("XB");
            this.Property(t => t.ZC).HasColumnName("ZC");
            this.Property(t => t.SYKS).HasColumnName("SYKS");
            this.Property(t => t.LXDH).HasColumnName("LXDH");
            this.Property(t => t.YX).HasColumnName("YX");
            this.Property(t => t.CSRQ).HasColumnName("CSRQ");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.REMARK).HasColumnName("REMARK");
            this.Property(t => t.PassPortID).HasColumnName("PassPortID");
            this.Property(t => t.CZYGH).HasColumnName("CZYGH");
            this.Property(t => t.CZYXM).HasColumnName("CZYXM");
            this.Property(t => t.CZSJ).HasColumnName("CZSJ");
            this.Property(t => t.JLSJ).HasColumnName("JLSJ");
            this.Property(t => t.SYKSMC).HasColumnName("SYKSMC");
            this.Property(t => t.GH).HasColumnName("GH");
            this.Property(t => t.SFZH).HasColumnName("SFZH");
        }
    }
}
