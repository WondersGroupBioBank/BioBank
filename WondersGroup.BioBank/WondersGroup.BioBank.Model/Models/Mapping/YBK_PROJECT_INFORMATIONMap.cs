using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_PROJECT_INFORMATIONMap : EntityTypeConfiguration<YBK_PROJECT_INFORMATION>
    {
        public YBK_PROJECT_INFORMATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.XMID);

            // Properties
            this.Property(t => t.XMMC)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.KTBH)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.ZJLY)
                .HasMaxLength(2);

            this.Property(t => t.ZJLYMC)
                .HasMaxLength(30);

            this.Property(t => t.XMFZRGH)
                .HasMaxLength(32);

            this.Property(t => t.XMFZRXM)
                .HasMaxLength(32);

            this.Property(t => t.XMZCY)
                .HasMaxLength(500);

            this.Property(t => t.BLZD)
                .HasMaxLength(500);

            this.Property(t => t.LXDH)
                .HasMaxLength(20);

            this.Property(t => t.SSKSMC)
                .HasMaxLength(64);

            this.Property(t => t.YJFASJLX_SYXYJ)
                .HasMaxLength(2);

            this.Property(t => t.YJFASJLX_GCXYJ)
                .HasMaxLength(2);

            this.Property(t => t.YJFASJLX_HGXFX)
                .HasMaxLength(2);

            this.Property(t => t.YJFASJLX_QZXFX)
                .HasMaxLength(2);

            this.Property(t => t.YBLX_ZZ)
                .HasMaxLength(2);

            this.Property(t => t.YBLX_XY)
                .HasMaxLength(2);

            this.Property(t => t.YBLX_NY)
                .HasMaxLength(2);

            this.Property(t => t.YBLX_QT)
                .HasMaxLength(2);

            this.Property(t => t.YBLX_QTMC)
                .HasMaxLength(50);

            this.Property(t => t.ZZYBCJFS_SS)
                .HasMaxLength(2);

            this.Property(t => t.ZZYBCJFS_HJ)
                .HasMaxLength(2);

            this.Property(t => t.XXZZDCYB)
                .HasMaxLength(2);

            this.Property(t => t.GDZZSLYB)
                .HasMaxLength(50);

            this.Property(t => t.WZXKNLXEDTA)
                .HasMaxLength(2);

            this.Property(t => t.WZXKNLXGS)
                .HasMaxLength(2);

            this.Property(t => t.WZXKNLXQT)
                .HasMaxLength(2);

            this.Property(t => t.QTLXYBSM)
                .HasMaxLength(1000);

            this.Property(t => t.EJGLXYSFXS)
                .HasMaxLength(2);

            this.Property(t => t.YBSYHJGFK)
                .HasMaxLength(500);

            this.Property(t => t.BZ)
                .HasMaxLength(1000);

            this.Property(t => t.XMZT)
                .HasMaxLength(2);

            this.Property(t => t.SPRGH)
                .HasMaxLength(32);

            this.Property(t => t.SPRXM)
                .HasMaxLength(32);

            this.Property(t => t.SPWTGYY)
                .HasMaxLength(200);

            this.Property(t => t.CJYXM)
                .HasMaxLength(32);

            this.Property(t => t.ZJCZYXM)
                .HasMaxLength(32);

            this.Property(t => t.SJZT)
                .HasMaxLength(2);

            this.Property(t => t.KTLLRGH)
                .HasMaxLength(32);

            this.Property(t => t.KTLLRXM)
                .HasMaxLength(32);

            this.Property(t => t.WZXKNLXGYSN)
                .HasMaxLength(2);

            this.Property(t => t.WZXKNLXQTMC)
                .HasMaxLength(200);

            this.Property(t => t.HZRXM)
                .HasMaxLength(32);

            this.Property(t => t.HZDW)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("YBK_PROJECT_INFORMATION");
            this.Property(t => t.XMID).HasColumnName("XMID");
            this.Property(t => t.XMMC).HasColumnName("XMMC");
            this.Property(t => t.KTBH).HasColumnName("KTBH");
            this.Property(t => t.ZJLY).HasColumnName("ZJLY");
            this.Property(t => t.ZJLYMC).HasColumnName("ZJLYMC");
            this.Property(t => t.SSJE).HasColumnName("SSJE");
            this.Property(t => t.XMFZRID).HasColumnName("XMFZRID");
            this.Property(t => t.XMFZRGH).HasColumnName("XMFZRGH");
            this.Property(t => t.XMFZRXM).HasColumnName("XMFZRXM");
            this.Property(t => t.XMZCY).HasColumnName("XMZCY");
            this.Property(t => t.BLZD).HasColumnName("BLZD");
            this.Property(t => t.KTQSSJ).HasColumnName("KTQSSJ");
            this.Property(t => t.LXDH).HasColumnName("LXDH");
            this.Property(t => t.SSKS).HasColumnName("SSKS");
            this.Property(t => t.SSKSMC).HasColumnName("SSKSMC");
            this.Property(t => t.YJFASJLX_SYXYJ).HasColumnName("YJFASJLX_SYXYJ");
            this.Property(t => t.YJFASJLX_GCXYJ).HasColumnName("YJFASJLX_GCXYJ");
            this.Property(t => t.YJFASJLX_HGXFX).HasColumnName("YJFASJLX_HGXFX");
            this.Property(t => t.YJFASJLX_QZXFX).HasColumnName("YJFASJLX_QZXFX");
            this.Property(t => t.YBLX_ZZ).HasColumnName("YBLX_ZZ");
            this.Property(t => t.YBLX_XY).HasColumnName("YBLX_XY");
            this.Property(t => t.YBLX_NY).HasColumnName("YBLX_NY");
            this.Property(t => t.YBLX_QT).HasColumnName("YBLX_QT");
            this.Property(t => t.YBLX_QTMC).HasColumnName("YBLX_QTMC");
            this.Property(t => t.ZZYBCJFS_SS).HasColumnName("ZZYBCJFS_SS");
            this.Property(t => t.ZZYBCJFS_HJ).HasColumnName("ZZYBCJFS_HJ");
            this.Property(t => t.XXZZDCYB).HasColumnName("XXZZDCYB");
            this.Property(t => t.GDZZSLYB).HasColumnName("GDZZSLYB");
            this.Property(t => t.WZXFKN).HasColumnName("WZXFKN");
            this.Property(t => t.WZXKN).HasColumnName("WZXKN");
            this.Property(t => t.WZXKNLXEDTA).HasColumnName("WZXKNLXEDTA");
            this.Property(t => t.WZXKNLXGS).HasColumnName("WZXKNLXGS");
            this.Property(t => t.WZXKNLXQT).HasColumnName("WZXKNLXQT");
            this.Property(t => t.NY).HasColumnName("NY");
            this.Property(t => t.QTLXYBSM).HasColumnName("QTLXYBSM");
            this.Property(t => t.EJGLXYSFXS).HasColumnName("EJGLXYSFXS");
            this.Property(t => t.YBSYHJGFK).HasColumnName("YBSYHJGFK");
            this.Property(t => t.BZ).HasColumnName("BZ");
            this.Property(t => t.XMZT).HasColumnName("XMZT");
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
            this.Property(t => t.WZXKNLXGYSN).HasColumnName("WZXKNLXGYSN");
            this.Property(t => t.WZXKNLXQTMC).HasColumnName("WZXKNLXQTMC");
            this.Property(t => t.HZRXM).HasColumnName("HZRXM");
            this.Property(t => t.HZDW).HasColumnName("HZDW");
        }
    }
}
