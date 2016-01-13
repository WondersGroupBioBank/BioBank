using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WondersGroup.BioBank.Model.Models.Mapping;

namespace WondersGroup.BioBank.Model.Models
{
    public partial class BioBankPassPortContext : DbContext
    {
        static BioBankPassPortContext()
        {
            Database.SetInitializer<BioBankPassPortContext>(null);
        }

        public BioBankPassPortContext()
            : base("Name=BioBankPassPortContext")
        {
        }

        public DbSet<TB_Module_JLB> TB_Module_JLB { get; set; }
        public DbSet<TB_ModuleFun_JLB> TB_ModuleFun_JLB { get; set; }
        public DbSet<TB_Passport_JLB> TB_Passport_JLB { get; set; }
        public DbSet<TB_PassportRole_GXB> TB_PassportRole_GXB { get; set; }
        public DbSet<TB_Role_JLB> TB_Role_JLB { get; set; }
        public DbSet<TB_RoleFun_GXB> TB_RoleFun_GXB { get; set; }
        public DbSet<TB_User_JLB> TB_User_JLB { get; set; }
        public DbSet<V_PassportList> V_PassportList { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TB_Module_JLBMap());
            modelBuilder.Configurations.Add(new TB_ModuleFun_JLBMap());
            modelBuilder.Configurations.Add(new TB_Passport_JLBMap());
            modelBuilder.Configurations.Add(new TB_PassportRole_GXBMap());
            modelBuilder.Configurations.Add(new TB_Role_JLBMap());
            modelBuilder.Configurations.Add(new TB_RoleFun_GXBMap());
            modelBuilder.Configurations.Add(new TB_User_JLBMap());
            modelBuilder.Configurations.Add(new V_PassportListMap());
        }
    }
}
