using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_DEVICE_ENTITY_INFORMATIONMap : EntityTypeConfiguration<YBK_DEVICE_ENTITY_INFORMATION>
    {
        public YBK_DEVICE_ENTITY_INFORMATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.STWYBH);

            // Properties
            this.Property(t => t.STWYBH)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.STLX)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.STLXMC)
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
            this.ToTable("YBK_DEVICE_ENTITY_INFORMATION");
            this.Property(t => t.STWYBH).HasColumnName("STWYBH");
            this.Property(t => t.STLX).HasColumnName("STLX");
            this.Property(t => t.STLXMC).HasColumnName("STLXMC");
            this.Property(t => t.SZKJXXID).HasColumnName("SZKJXXID");
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
