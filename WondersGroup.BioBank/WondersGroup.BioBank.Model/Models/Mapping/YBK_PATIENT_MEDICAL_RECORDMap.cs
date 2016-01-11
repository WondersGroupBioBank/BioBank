using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_PATIENT_MEDICAL_RECORDMap : EntityTypeConfiguration<YBK_PATIENT_MEDICAL_RECORD>
    {
        public YBK_PATIENT_MEDICAL_RECORDMap()
        {
            // Primary Key
            this.HasKey(t => t.JZID);

            // Properties
            this.Property(t => t.HZID)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.JZRQ)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.MZZYBZ)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.ZD)
                .HasMaxLength(200);

            this.Property(t => t.ZDMC)
                .HasMaxLength(200);

            this.Property(t => t.YBLX)
                .HasMaxLength(200);

            this.Property(t => t.YBLXMC)
                .HasMaxLength(200);

            this.Property(t => t.JZBH)
                .HasMaxLength(200);

            this.Property(t => t.JZKS)
                .HasMaxLength(200);

            this.Property(t => t.JZKSMC)
                .HasMaxLength(200);

            this.Property(t => t.YS)
                .HasMaxLength(200);

            this.Property(t => t.YSMC)
                .HasMaxLength(200);

            this.Property(t => t.BQ)
                .HasMaxLength(200);

            this.Property(t => t.BQMC)
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

            this.Property(t => t.SJLY)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.SJLYID)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("YBK_PATIENT_MEDICAL_RECORD");
            this.Property(t => t.JZID).HasColumnName("JZID");
            this.Property(t => t.HZID).HasColumnName("HZID");
            this.Property(t => t.JZRQ).HasColumnName("JZRQ");
            this.Property(t => t.MZZYBZ).HasColumnName("MZZYBZ");
            this.Property(t => t.ZD).HasColumnName("ZD");
            this.Property(t => t.ZDMC).HasColumnName("ZDMC");
            this.Property(t => t.YBLX).HasColumnName("YBLX");
            this.Property(t => t.YBLXMC).HasColumnName("YBLXMC");
            this.Property(t => t.JZBH).HasColumnName("JZBH");
            this.Property(t => t.JZKS).HasColumnName("JZKS");
            this.Property(t => t.JZKSMC).HasColumnName("JZKSMC");
            this.Property(t => t.YS).HasColumnName("YS");
            this.Property(t => t.YSMC).HasColumnName("YSMC");
            this.Property(t => t.BQ).HasColumnName("BQ");
            this.Property(t => t.BQMC).HasColumnName("BQMC");
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
