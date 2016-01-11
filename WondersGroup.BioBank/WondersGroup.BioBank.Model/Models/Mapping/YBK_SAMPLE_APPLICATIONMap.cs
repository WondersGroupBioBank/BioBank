using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_SAMPLE_APPLICATIONMap : EntityTypeConfiguration<YBK_SAMPLE_APPLICATION>
    {
        public YBK_SAMPLE_APPLICATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.YBSQID);

            // Properties
            this.Property(t => t.SQRGH)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.SQRXM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.SQKSMC)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.HZID)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.HZXM)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.XMMC)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.JZBH)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ZD)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ZDMC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.SFYZQTYS)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.BDGRJCJG_HIV)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.BDGRJCJG_HIVMC)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.BDGRJCJG_HBV)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.BDGRJCJG_HBVMC)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.BZ)
                .HasMaxLength(1000);

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

            this.Property(t => t.SFZH)
                .HasMaxLength(200);

            this.Property(t => t.KTLLRGH)
                .HasMaxLength(32);

            this.Property(t => t.KTLLRXM)
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("YBK_SAMPLE_APPLICATION");
            this.Property(t => t.YBSQID).HasColumnName("YBSQID");
            this.Property(t => t.SQSJ).HasColumnName("SQSJ");
            this.Property(t => t.SQRQ).HasColumnName("SQRQ");
            this.Property(t => t.SQRID).HasColumnName("SQRID");
            this.Property(t => t.SQRGH).HasColumnName("SQRGH");
            this.Property(t => t.SQRXM).HasColumnName("SQRXM");
            this.Property(t => t.SQKS).HasColumnName("SQKS");
            this.Property(t => t.SQKSMC).HasColumnName("SQKSMC");
            this.Property(t => t.XMID).HasColumnName("XMID");
            this.Property(t => t.HZID).HasColumnName("HZID");
            this.Property(t => t.HZXM).HasColumnName("HZXM");
            this.Property(t => t.JZID).HasColumnName("JZID");
            this.Property(t => t.XMMC).HasColumnName("XMMC");
            this.Property(t => t.JZBH).HasColumnName("JZBH");
            this.Property(t => t.ZD).HasColumnName("ZD");
            this.Property(t => t.ZDMC).HasColumnName("ZDMC");
            this.Property(t => t.SFYZQTYS).HasColumnName("SFYZQTYS");
            this.Property(t => t.BDGRJCJG_HIV).HasColumnName("BDGRJCJG_HIV");
            this.Property(t => t.BDGRJCJG_HIVMC).HasColumnName("BDGRJCJG_HIVMC");
            this.Property(t => t.BDGRJCJG_HBV).HasColumnName("BDGRJCJG_HBV");
            this.Property(t => t.BDGRJCJG_HBVMC).HasColumnName("BDGRJCJG_HBVMC");
            this.Property(t => t.BZ).HasColumnName("BZ");
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
            this.Property(t => t.SFZH).HasColumnName("SFZH");
            this.Property(t => t.KTLLRID).HasColumnName("KTLLRID");
            this.Property(t => t.KTLLRGH).HasColumnName("KTLLRGH");
            this.Property(t => t.KTLLRXM).HasColumnName("KTLLRXM");
        }
    }
}
