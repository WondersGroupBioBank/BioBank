using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class INTERFACE_HIS_PATIENT_INFOMap : EntityTypeConfiguration<INTERFACE_HIS_PATIENT_INFO>
    {
        public INTERFACE_HIS_PATIENT_INFOMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.PATIENTID)
                .HasMaxLength(200);

            this.Property(t => t.HOSPNO)
                .HasMaxLength(200);

            this.Property(t => t.PATNAME)
                .HasMaxLength(200);

            this.Property(t => t.SEX)
                .HasMaxLength(200);

            this.Property(t => t.AGE)
                .HasMaxLength(200);

            this.Property(t => t.AGEUNIT)
                .HasMaxLength(200);

            this.Property(t => t.WARDORREG)
                .HasMaxLength(200);

            this.Property(t => t.CHARGETYPE)
                .HasMaxLength(200);

            this.Property(t => t.CURENO)
                .HasMaxLength(200);

            this.Property(t => t.CARDNO)
                .HasMaxLength(200);

            this.Property(t => t.APPLYDEPT)
                .HasMaxLength(200);

            this.Property(t => t.WARD)
                .HasMaxLength(200);

            this.Property(t => t.BEDNO)
                .HasMaxLength(200);

            this.Property(t => t.APPLYDOCTOR)
                .HasMaxLength(200);

            this.Property(t => t.CLINCDESC)
                .HasMaxLength(200);

            this.Property(t => t.IDNUM)
                .HasMaxLength(200);

            this.Property(t => t.PHONE)
                .HasMaxLength(200);

            this.Property(t => t.ADDRESS)
                .HasMaxLength(200);

            this.Property(t => t.ZIP)
                .HasMaxLength(200);

            this.Property(t => t.CAREER)
                .HasMaxLength(200);

            this.Property(t => t.NATION)
                .HasMaxLength(200);

            this.Property(t => t.TODOC)
                .HasMaxLength(200);

            this.Property(t => t.SENDNO)
                .HasMaxLength(200);

            this.Property(t => t.SYXH)
                .HasMaxLength(200);

            this.Property(t => t.BQMC)
                .HasMaxLength(200);

            this.Property(t => t.YEXH)
                .HasMaxLength(200);

            this.Property(t => t.DEPTNAME)
                .HasMaxLength(200);

            this.Property(t => t.JZLSH)
                .HasMaxLength(200);

            this.Property(t => t.KLX)
                .HasMaxLength(200);

            this.Property(t => t.CLINCNAME)
                .HasMaxLength(200);

            this.Property(t => t.BIRTH)
                .HasMaxLength(200);

            this.Property(t => t.MZZYBZ)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("INTERFACE_HIS_PATIENT_INFO");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PATIENTID).HasColumnName("PATIENTID");
            this.Property(t => t.HOSPNO).HasColumnName("HOSPNO");
            this.Property(t => t.PATNAME).HasColumnName("PATNAME");
            this.Property(t => t.SEX).HasColumnName("SEX");
            this.Property(t => t.AGE).HasColumnName("AGE");
            this.Property(t => t.AGEUNIT).HasColumnName("AGEUNIT");
            this.Property(t => t.WARDORREG).HasColumnName("WARDORREG");
            this.Property(t => t.CHARGETYPE).HasColumnName("CHARGETYPE");
            this.Property(t => t.CURENO).HasColumnName("CURENO");
            this.Property(t => t.CARDNO).HasColumnName("CARDNO");
            this.Property(t => t.APPLYDEPT).HasColumnName("APPLYDEPT");
            this.Property(t => t.WARD).HasColumnName("WARD");
            this.Property(t => t.BEDNO).HasColumnName("BEDNO");
            this.Property(t => t.APPLYDOCTOR).HasColumnName("APPLYDOCTOR");
            this.Property(t => t.CLINCDESC).HasColumnName("CLINCDESC");
            this.Property(t => t.IDNUM).HasColumnName("IDNUM");
            this.Property(t => t.PHONE).HasColumnName("PHONE");
            this.Property(t => t.ADDRESS).HasColumnName("ADDRESS");
            this.Property(t => t.ZIP).HasColumnName("ZIP");
            this.Property(t => t.CAREER).HasColumnName("CAREER");
            this.Property(t => t.NATION).HasColumnName("NATION");
            this.Property(t => t.TODOC).HasColumnName("TODOC");
            this.Property(t => t.SENDNO).HasColumnName("SENDNO");
            this.Property(t => t.SYXH).HasColumnName("SYXH");
            this.Property(t => t.BQMC).HasColumnName("BQMC");
            this.Property(t => t.YEXH).HasColumnName("YEXH");
            this.Property(t => t.DEPTNAME).HasColumnName("DEPTNAME");
            this.Property(t => t.JZLSH).HasColumnName("JZLSH");
            this.Property(t => t.KLX).HasColumnName("KLX");
            this.Property(t => t.CLINCNAME).HasColumnName("CLINCNAME");
            this.Property(t => t.BIRTH).HasColumnName("BIRTH");
            this.Property(t => t.MZZYBZ).HasColumnName("MZZYBZ");
            this.Property(t => t.CJSJ).HasColumnName("CJSJ");
        }
    }
}
