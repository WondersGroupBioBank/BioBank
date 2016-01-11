using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_PATIENT_PATIENTINFOMap : EntityTypeConfiguration<YBK_PATIENT_PATIENTINFO>
    {
        public YBK_PATIENT_PATIENTINFOMap()
        {
            // Primary Key
            this.HasKey(t => t.HZID);

            // Properties
            this.Property(t => t.HZID)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.XM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.XB)
                .HasMaxLength(1);

            this.Property(t => t.XBMC)
                .HasMaxLength(20);

            this.Property(t => t.DHHM)
                .HasMaxLength(24);

            this.Property(t => t.JZD)
                .HasMaxLength(128);

            this.Property(t => t.JZDYB)
                .HasMaxLength(6);

            this.Property(t => t.ZYBM)
                .HasMaxLength(16);

            this.Property(t => t.ZYBMMC)
                .HasMaxLength(100);

            this.Property(t => t.MZ)
                .HasMaxLength(5);

            this.Property(t => t.MZMC)
                .HasMaxLength(50);

            this.Property(t => t.HYZK)
                .HasMaxLength(2);

            this.Property(t => t.HYZKMC)
                .HasMaxLength(50);

            this.Property(t => t.CSRQ)
                .HasMaxLength(50);

            this.Property(t => t.CJYXM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ZJCZYXM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SJZT)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SJLY)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.SJLYID)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("YBK_PATIENT_PATIENTINFO");
            this.Property(t => t.HZID).HasColumnName("HZID");
            this.Property(t => t.XM).HasColumnName("XM");
            this.Property(t => t.XB).HasColumnName("XB");
            this.Property(t => t.XBMC).HasColumnName("XBMC");
            this.Property(t => t.NL).HasColumnName("NL");
            this.Property(t => t.DHHM).HasColumnName("DHHM");
            this.Property(t => t.JZD).HasColumnName("JZD");
            this.Property(t => t.JZDYB).HasColumnName("JZDYB");
            this.Property(t => t.ZYBM).HasColumnName("ZYBM");
            this.Property(t => t.ZYBMMC).HasColumnName("ZYBMMC");
            this.Property(t => t.MZ).HasColumnName("MZ");
            this.Property(t => t.MZMC).HasColumnName("MZMC");
            this.Property(t => t.HYZK).HasColumnName("HYZK");
            this.Property(t => t.HYZKMC).HasColumnName("HYZKMC");
            this.Property(t => t.CSRQ).HasColumnName("CSRQ");
            this.Property(t => t.CJYID).HasColumnName("CJYID");
            this.Property(t => t.CJYXM).HasColumnName("CJYXM");
            this.Property(t => t.CJSJ).HasColumnName("CJSJ");
            this.Property(t => t.ZJCZYID).HasColumnName("ZJCZYID");
            this.Property(t => t.ZJCZYXM).HasColumnName("ZJCZYXM");
            this.Property(t => t.ZJCZSJ).HasColumnName("ZJCZSJ");
            this.Property(t => t.SJZT).HasColumnName("SJZT");
            this.Property(t => t.SJLY).HasColumnName("SJLY");
            this.Property(t => t.SJLYID).HasColumnName("SJLYID");
        }
    }
}
