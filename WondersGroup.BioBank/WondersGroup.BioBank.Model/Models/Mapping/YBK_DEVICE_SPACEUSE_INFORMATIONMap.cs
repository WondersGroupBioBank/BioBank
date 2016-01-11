using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class YBK_DEVICE_SPACEUSE_INFORMATIONMap : EntityTypeConfiguration<YBK_DEVICE_SPACEUSE_INFORMATION>
    {
        public YBK_DEVICE_SPACEUSE_INFORMATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.KJXXID);

            // Properties
            this.Property(t => t.KJXXMC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.STWYBH)
                .HasMaxLength(200);

            this.Property(t => t.BZ)
                .HasMaxLength(1000);

            this.Property(t => t.SSYBLX)
                .HasMaxLength(100);

            this.Property(t => t.SSKSMC)
                .HasMaxLength(64);

            this.Property(t => t.SSSBBH)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.SSSBMC)
                .IsRequired()
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

            this.Property(t => t.KJLX)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.KJLXMC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BCBH)
                .HasMaxLength(200);

            this.Property(t => t.BCBHSY)
                .HasMaxLength(200);

            this.Property(t => t.BCKJIDSY)
                .HasMaxLength(200);

            this.Property(t => t.BHDYYBLX)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("YBK_DEVICE_SPACEUSE_INFORMATION");
            this.Property(t => t.KJXXID).HasColumnName("KJXXID");
            this.Property(t => t.KJXXMC).HasColumnName("KJXXMC");
            this.Property(t => t.KJCFSTID).HasColumnName("KJCFSTID");
            this.Property(t => t.STWYBH).HasColumnName("STWYBH");
            this.Property(t => t.BZ).HasColumnName("BZ");
            this.Property(t => t.SSXMID).HasColumnName("SSXMID");
            this.Property(t => t.SSYBLX).HasColumnName("SSYBLX");
            this.Property(t => t.SSHZ).HasColumnName("SSHZ");
            this.Property(t => t.SSKS).HasColumnName("SSKS");
            this.Property(t => t.SSKSMC).HasColumnName("SSKSMC");
            this.Property(t => t.SSSBID).HasColumnName("SSSBID");
            this.Property(t => t.SSSBLXID).HasColumnName("SSSBLXID");
            this.Property(t => t.SSSBBH).HasColumnName("SSSBBH");
            this.Property(t => t.SJKJXXID).HasColumnName("SJKJXXID");
            this.Property(t => t.SSSBMC).HasColumnName("SSSBMC");
            this.Property(t => t.CJYID).HasColumnName("CJYID");
            this.Property(t => t.CJYXM).HasColumnName("CJYXM");
            this.Property(t => t.CJSJ).HasColumnName("CJSJ");
            this.Property(t => t.ZJCZYID).HasColumnName("ZJCZYID");
            this.Property(t => t.ZJCZYXM).HasColumnName("ZJCZYXM");
            this.Property(t => t.ZJCZSJ).HasColumnName("ZJCZSJ");
            this.Property(t => t.SJZT).HasColumnName("SJZT");
            this.Property(t => t.SCKJLXID).HasColumnName("SCKJLXID");
            this.Property(t => t.KJLXID).HasColumnName("KJLXID");
            this.Property(t => t.KJLX).HasColumnName("KJLX");
            this.Property(t => t.KJLXMC).HasColumnName("KJLXMC");
            this.Property(t => t.CC).HasColumnName("CC");
            this.Property(t => t.SBKJWZID).HasColumnName("SBKJWZID");
            this.Property(t => t.BCBH).HasColumnName("BCBH");
            this.Property(t => t.BCBHSY).HasColumnName("BCBHSY");
            this.Property(t => t.BCKJIDSY).HasColumnName("BCKJIDSY");
            this.Property(t => t.KJGID).HasColumnName("KJGID");
            this.Property(t => t.BHYBLXS).HasColumnName("BHYBLXS");
            this.Property(t => t.BHDYYBLX).HasColumnName("BHDYYBLX");
            this.Property(t => t.BHKJZS).HasColumnName("BHKJZS");
            this.Property(t => t.BHKJSYS).HasColumnName("BHKJSYS");
        }
    }
}
