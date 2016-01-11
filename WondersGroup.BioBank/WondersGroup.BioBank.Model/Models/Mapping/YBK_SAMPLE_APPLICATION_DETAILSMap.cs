using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_SAMPLE_APPLICATION_DETAILSMap : EntityTypeConfiguration<YBK_SAMPLE_APPLICATION_DETAILS>
    {
        public YBK_SAMPLE_APPLICATION_DETAILSMap()
        {
            // Primary Key
            this.HasKey(t => t.YBSQMXID);

            // Properties
            this.Property(t => t.YBLXYJDM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.YBLXYJDMMC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.YBLXEJDM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.YBLXEJDMMC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.XYLXDM)
                .HasMaxLength(20);

            this.Property(t => t.XYLXDMMC)
                .HasMaxLength(100);

            this.Property(t => t.QGSSDM)
                .HasMaxLength(20);

            this.Property(t => t.QGSSDMMC)
                .HasMaxLength(100);

            this.Property(t => t.QGMCDM)
                .HasMaxLength(20);

            this.Property(t => t.QGMCDMMC)
                .HasMaxLength(100);

            this.Property(t => t.CJJDDM)
                .HasMaxLength(20);

            this.Property(t => t.CJJDDMMC)
                .HasMaxLength(100);

            this.Property(t => t.CJLXDM)
                .HasMaxLength(20);

            this.Property(t => t.CJLXDMMC)
                .HasMaxLength(100);

            this.Property(t => t.YBCLDM)
                .HasMaxLength(100);

            this.Property(t => t.YBCLDMMC)
                .HasMaxLength(200);

            this.Property(t => t.LXYCSJDMMC)
                .HasMaxLength(100);

            this.Property(t => t.LXYCSJDM)
                .HasMaxLength(20);

            this.Property(t => t.DYCLXSJDM)
                .HasMaxLength(20);

            this.Property(t => t.DYCLXSJDMMC)
                .HasMaxLength(100);

            this.Property(t => t.DECLXSJDM)
                .HasMaxLength(20);

            this.Property(t => t.DECLXSJDMMC)
                .HasMaxLength(100);

            this.Property(t => t.LXHSJDM)
                .HasMaxLength(20);

            this.Property(t => t.LXHSJDMMC)
                .HasMaxLength(100);

            this.Property(t => t.CQCCDM)
                .HasMaxLength(20);

            this.Property(t => t.CQCCDMMC)
                .HasMaxLength(100);

            this.Property(t => t.GDJLXDM)
                .HasMaxLength(20);

            this.Property(t => t.GDJLXDMMC)
                .HasMaxLength(100);

            this.Property(t => t.BLH)
                .HasMaxLength(100);

            this.Property(t => t.YWZP)
                .HasMaxLength(20);

            this.Property(t => t.BZ)
                .HasMaxLength(1000);

            this.Property(t => t.CJSJDM)
                .HasMaxLength(20);

            this.Property(t => t.CJSJDMMC)
                .HasMaxLength(200);

            this.Property(t => t.CJSJQT)
                .HasMaxLength(200);

            this.Property(t => t.CJRGH)
                .HasMaxLength(32);

            this.Property(t => t.CJRXM)
                .HasMaxLength(32);

            this.Property(t => t.CJDZDM)
                .HasMaxLength(20);

            this.Property(t => t.CJDZDMMC)
                .HasMaxLength(200);

            this.Property(t => t.BLZDDM)
                .HasMaxLength(50);

            this.Property(t => t.BLZDMC)
                .HasMaxLength(200);

            this.Property(t => t.SFSJ)
                .HasMaxLength(20);

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
            this.ToTable("YBK_SAMPLE_APPLICATION_DETAILS");
            this.Property(t => t.YBSQMXID).HasColumnName("YBSQMXID");
            this.Property(t => t.YBSQID).HasColumnName("YBSQID");
            this.Property(t => t.YBLXYJDM).HasColumnName("YBLXYJDM");
            this.Property(t => t.YBLXYJDMMC).HasColumnName("YBLXYJDMMC");
            this.Property(t => t.YBLXEJDM).HasColumnName("YBLXEJDM");
            this.Property(t => t.YBLXEJDMMC).HasColumnName("YBLXEJDMMC");
            this.Property(t => t.XYLXDM).HasColumnName("XYLXDM");
            this.Property(t => t.XYLXDMMC).HasColumnName("XYLXDMMC");
            this.Property(t => t.QGSSDM).HasColumnName("QGSSDM");
            this.Property(t => t.QGSSDMMC).HasColumnName("QGSSDMMC");
            this.Property(t => t.QGMCDM).HasColumnName("QGMCDM");
            this.Property(t => t.QGMCDMMC).HasColumnName("QGMCDMMC");
            this.Property(t => t.JJC).HasColumnName("JJC");
            this.Property(t => t.CJJDDM).HasColumnName("CJJDDM");
            this.Property(t => t.CJJDDMMC).HasColumnName("CJJDDMMC");
            this.Property(t => t.CJLXDM).HasColumnName("CJLXDM");
            this.Property(t => t.CJLXDMMC).HasColumnName("CJLXDMMC");
            this.Property(t => t.CAIJSJ).HasColumnName("CAIJSJ");
            this.Property(t => t.LTSJ).HasColumnName("LTSJ");
            this.Property(t => t.YBDJ).HasColumnName("YBDJ");
            this.Property(t => t.YBCLDM).HasColumnName("YBCLDM");
            this.Property(t => t.YBCLDMMC).HasColumnName("YBCLDMMC");
            this.Property(t => t.YBSL).HasColumnName("YBSL");
            this.Property(t => t.YBTJ).HasColumnName("YBTJ");
            this.Property(t => t.QCLSJ).HasColumnName("QCLSJ");
            this.Property(t => t.LXYCSJDMMC).HasColumnName("LXYCSJDMMC");
            this.Property(t => t.LXYCSJDM).HasColumnName("LXYCSJDM");
            this.Property(t => t.DYCLXSJDM).HasColumnName("DYCLXSJDM");
            this.Property(t => t.DYCLXSJDMMC).HasColumnName("DYCLXSJDMMC");
            this.Property(t => t.DECLXSJDM).HasColumnName("DECLXSJDM");
            this.Property(t => t.DECLXSJDMMC).HasColumnName("DECLXSJDMMC");
            this.Property(t => t.LXHSJDM).HasColumnName("LXHSJDM");
            this.Property(t => t.LXHSJDMMC).HasColumnName("LXHSJDMMC");
            this.Property(t => t.CQCCDM).HasColumnName("CQCCDM");
            this.Property(t => t.CQCCDMMC).HasColumnName("CQCCDMMC");
            this.Property(t => t.RQXSJ).HasColumnName("RQXSJ");
            this.Property(t => t.LQXSJ).HasColumnName("LQXSJ");
            this.Property(t => t.GDJLXDM).HasColumnName("GDJLXDM");
            this.Property(t => t.GDJLXDMMC).HasColumnName("GDJLXDMMC");
            this.Property(t => t.JBSJ).HasColumnName("JBSJ");
            this.Property(t => t.MZSJ).HasColumnName("MZSJ");
            this.Property(t => t.GDSJ).HasColumnName("GDSJ");
            this.Property(t => t.CCSJ).HasColumnName("CCSJ");
            this.Property(t => t.SJSJ).HasColumnName("SJSJ");
            this.Property(t => t.SJRQ).HasColumnName("SJRQ");
            this.Property(t => t.BLH).HasColumnName("BLH");
            this.Property(t => t.YWZP).HasColumnName("YWZP");
            this.Property(t => t.BZ).HasColumnName("BZ");
            this.Property(t => t.CJSJDM).HasColumnName("CJSJDM");
            this.Property(t => t.CJSJDMMC).HasColumnName("CJSJDMMC");
            this.Property(t => t.CJSJQT).HasColumnName("CJSJQT");
            this.Property(t => t.CJJDSJDN).HasColumnName("CJJDSJDN");
            this.Property(t => t.CJJDSJDY).HasColumnName("CJJDSJDY");
            this.Property(t => t.CJJDSJDZ).HasColumnName("CJJDSJDZ");
            this.Property(t => t.CJJDSJDR).HasColumnName("CJJDSJDR");
            this.Property(t => t.CJJDSJDXS).HasColumnName("CJJDSJDXS");
            this.Property(t => t.CJRID).HasColumnName("CJRID");
            this.Property(t => t.CJRGH).HasColumnName("CJRGH");
            this.Property(t => t.CJRXM).HasColumnName("CJRXM");
            this.Property(t => t.CJDZDM).HasColumnName("CJDZDM");
            this.Property(t => t.CJDZDMMC).HasColumnName("CJDZDMMC");
            this.Property(t => t.SSKSSJ).HasColumnName("SSKSSJ");
            this.Property(t => t.BLZDDM).HasColumnName("BLZDDM");
            this.Property(t => t.BLZDMC).HasColumnName("BLZDMC");
            this.Property(t => t.SFSJ).HasColumnName("SFSJ");
            this.Property(t => t.YBZL).HasColumnName("YBZL");
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
