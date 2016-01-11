using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_PATIENT_CARDMap : EntityTypeConfiguration<YBK_PATIENT_CARD>
    {
        public YBK_PATIENT_CARDMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.HZID)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.RZLX)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.RZLXMC)
                .HasMaxLength(50);

            this.Property(t => t.RZHM)
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
            this.ToTable("YBK_PATIENT_CARD");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HZID).HasColumnName("HZID");
            this.Property(t => t.RZLX).HasColumnName("RZLX");
            this.Property(t => t.RZLXMC).HasColumnName("RZLXMC");
            this.Property(t => t.RZHM).HasColumnName("RZHM");
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
