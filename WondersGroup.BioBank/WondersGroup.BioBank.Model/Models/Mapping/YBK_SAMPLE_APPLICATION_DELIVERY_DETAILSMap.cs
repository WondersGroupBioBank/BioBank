using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_SAMPLE_APPLICATION_DELIVERY_DETAILSMap : EntityTypeConfiguration<YBK_SAMPLE_APPLICATION_DELIVERY_DETAILS>
    {
        public YBK_SAMPLE_APPLICATION_DELIVERY_DETAILSMap()
        {
            // Primary Key
            this.HasKey(t => t.CKSQMXID);

            // Properties
            this.Property(t => t.SFHK)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.CJYXM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ZJCZYXM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.SJZT)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("YBK_SAMPLE_APPLICATION_DELIVERY_DETAILS");
            this.Property(t => t.YBID).HasColumnName("YBID");
            this.Property(t => t.CKSQMXID).HasColumnName("CKSQMXID");
            this.Property(t => t.CKSQID).HasColumnName("CKSQID");
            this.Property(t => t.SFHK).HasColumnName("SFHK");
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
