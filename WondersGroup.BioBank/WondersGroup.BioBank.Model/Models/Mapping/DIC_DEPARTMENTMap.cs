using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WondersGroup.BioBank.Model.Models.Mapping
{
    public class DIC_DEPARTMENTMap : EntityTypeConfiguration<DIC_DEPARTMENT>
    {
        public DIC_DEPARTMENTMap()
        {
            // Primary Key
            this.HasKey(t => t.KSID);

            // Properties
            this.Property(t => t.KSDM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.KSJC)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.KSQC)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.KSLX)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.CZYGH)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CZYXM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CJYXM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ZJCZYXM)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.SJZT)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.PYM)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DIC_DEPARTMENT");
            this.Property(t => t.KSID).HasColumnName("KSID");
            this.Property(t => t.FID).HasColumnName("FID");
            this.Property(t => t.KSDM).HasColumnName("KSDM");
            this.Property(t => t.KSJC).HasColumnName("KSJC");
            this.Property(t => t.KSQC).HasColumnName("KSQC");
            this.Property(t => t.KSLX).HasColumnName("KSLX");
            this.Property(t => t.MRQXCZYID).HasColumnName("MRQXCZYID");
            this.Property(t => t.CZYGH).HasColumnName("CZYGH");
            this.Property(t => t.CZYXM).HasColumnName("CZYXM");
            this.Property(t => t.CZRQSJ).HasColumnName("CZRQSJ");
            this.Property(t => t.CJYID).HasColumnName("CJYID");
            this.Property(t => t.CJYXM).HasColumnName("CJYXM");
            this.Property(t => t.CJSJ).HasColumnName("CJSJ");
            this.Property(t => t.ZJCZYID).HasColumnName("ZJCZYID");
            this.Property(t => t.ZJCZYXM).HasColumnName("ZJCZYXM");
            this.Property(t => t.ZJCZSJ).HasColumnName("ZJCZSJ");
            this.Property(t => t.SJZT).HasColumnName("SJZT");
            this.Property(t => t.PYM).HasColumnName("PYM");
        }
    }
}
