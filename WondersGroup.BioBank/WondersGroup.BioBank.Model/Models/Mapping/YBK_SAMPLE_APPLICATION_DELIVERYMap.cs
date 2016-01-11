using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_SAMPLE_APPLICATION_DELIVERYMap : EntityTypeConfiguration<YBK_SAMPLE_APPLICATION_DELIVERY>
    {
        public YBK_SAMPLE_APPLICATION_DELIVERYMap()
        {
            // Primary Key
            this.HasKey(t => t.CKSQID);

            // Properties
            this.Property(t => t.XMMC)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.KTMC)
                .HasMaxLength(100);

            this.Property(t => t.KTBH)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.ZJLY)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ZJLYMC)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.SQRGH)
                .HasMaxLength(32);

            this.Property(t => t.SQRXM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BLZD)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.LXDH)
                .HasMaxLength(20);

            this.Property(t => t.YX)
                .HasMaxLength(50);

            this.Property(t => t.SSKSMC)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.BZ)
                .HasMaxLength(4000);

            this.Property(t => t.SFDY)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.SQZT)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.SPRGH)
                .HasMaxLength(32);

            this.Property(t => t.SPRXM)
                .HasMaxLength(32);

            this.Property(t => t.SPWTGYY)
                .HasMaxLength(200);

            this.Property(t => t.CJYXM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ZJCZYXM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.SJZT)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.KTLLRGH)
                .HasMaxLength(32);

            this.Property(t => t.KTLLRXM)
                .HasMaxLength(32);

            this.Property(t => t.HZRXM)
                .HasMaxLength(32);

            this.Property(t => t.HZDW)
                .HasMaxLength(200);

            this.Property(t => t.JGFK)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("YBK_SAMPLE_APPLICATION_DELIVERY");
            this.Property(t => t.CKSQID).HasColumnName("CKSQID");
            this.Property(t => t.XMID).HasColumnName("XMID");
            this.Property(t => t.XMMC).HasColumnName("XMMC");
            this.Property(t => t.KTMC).HasColumnName("KTMC");
            this.Property(t => t.KTBH).HasColumnName("KTBH");
            this.Property(t => t.ZJLY).HasColumnName("ZJLY");
            this.Property(t => t.ZJLYMC).HasColumnName("ZJLYMC");
            this.Property(t => t.SSJE).HasColumnName("SSJE");
            this.Property(t => t.SQRID).HasColumnName("SQRID");
            this.Property(t => t.SQRGH).HasColumnName("SQRGH");
            this.Property(t => t.SQRXM).HasColumnName("SQRXM");
            this.Property(t => t.SQSJ).HasColumnName("SQSJ");
            this.Property(t => t.BLZD).HasColumnName("BLZD");
            this.Property(t => t.LXDH).HasColumnName("LXDH");
            this.Property(t => t.YX).HasColumnName("YX");
            this.Property(t => t.SSKS).HasColumnName("SSKS");
            this.Property(t => t.SSKSMC).HasColumnName("SSKSMC");
            this.Property(t => t.BZ).HasColumnName("BZ");
            this.Property(t => t.SFDY).HasColumnName("SFDY");
            this.Property(t => t.SQZT).HasColumnName("SQZT");
            this.Property(t => t.SPRID).HasColumnName("SPRID");
            this.Property(t => t.SPRGH).HasColumnName("SPRGH");
            this.Property(t => t.SPRXM).HasColumnName("SPRXM");
            this.Property(t => t.SPSJ).HasColumnName("SPSJ");
            this.Property(t => t.SPWTGYY).HasColumnName("SPWTGYY");
            this.Property(t => t.CJYID).HasColumnName("CJYID");
            this.Property(t => t.CJYXM).HasColumnName("CJYXM");
            this.Property(t => t.CJSJ).HasColumnName("CJSJ");
            this.Property(t => t.ZJCZYID).HasColumnName("ZJCZYID");
            this.Property(t => t.ZJCZYXM).HasColumnName("ZJCZYXM");
            this.Property(t => t.ZJCZSJ).HasColumnName("ZJCZSJ");
            this.Property(t => t.SJZT).HasColumnName("SJZT");
            this.Property(t => t.KTLLRID).HasColumnName("KTLLRID");
            this.Property(t => t.KTLLRGH).HasColumnName("KTLLRGH");
            this.Property(t => t.KTLLRXM).HasColumnName("KTLLRXM");
            this.Property(t => t.HZRXM).HasColumnName("HZRXM");
            this.Property(t => t.HZDW).HasColumnName("HZDW");
            this.Property(t => t.JGFK).HasColumnName("JGFK");
        }
    }
}
