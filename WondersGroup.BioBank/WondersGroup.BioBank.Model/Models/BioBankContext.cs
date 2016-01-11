using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WondersGroup.BioBank.Model.Models.Mapping;

namespace WondersGroup.BioBank.Model.Models
{
    public partial class BioBankContext : DbContext
    {
        static BioBankContext()
        {
            Database.SetInitializer<BioBankContext>(null);
        }

        public BioBankContext()
            : base("Name=BioBankContext")
        {
        }

        public DbSet<DIC_DEPARTMENT> DIC_DEPARTMENT { get; set; }
        public DbSet<DIC_DEVICE_TYPE> DIC_DEVICE_TYPE { get; set; }
        public DbSet<DIC_GENERAL> DIC_GENERAL { get; set; }
        public DbSet<DIC_PRACTITIONER> DIC_PRACTITIONER { get; set; }
        public DbSet<DIC_SAMPLE_DEAL> DIC_SAMPLE_DEAL { get; set; }
        public DbSet<DIC_SAMPLE_ORGAN> DIC_SAMPLE_ORGAN { get; set; }
        public DbSet<DIC_SAMPLE_TYPE> DIC_SAMPLE_TYPE { get; set; }
        public DbSet<DIC_SAMPLE_TYPE_bak> DIC_SAMPLE_TYPE_bak { get; set; }
        public DbSet<DIC_SPACE_TYPE> DIC_SPACE_TYPE { get; set; }
        public DbSet<INTERFACE_HIS_PATIENT_INFO> INTERFACE_HIS_PATIENT_INFO { get; set; }
        public DbSet<RULE_BH_MAKE> RULE_BH_MAKE { get; set; }
        public DbSet<RULE_DEVICE_NUMBER> RULE_DEVICE_NUMBER { get; set; }
        public DbSet<RULE_DEVICE_TPYESPACE_LOCATION> RULE_DEVICE_TPYESPACE_LOCATION { get; set; }
        public DbSet<RULE_DEVICE_TPYESPACE_RELATION> RULE_DEVICE_TPYESPACE_RELATION { get; set; }
        public DbSet<RULE_DEVICE_TYPESPACE_DEFINE> RULE_DEVICE_TYPESPACE_DEFINE { get; set; }
        public DbSet<RULE_DEVICE_TYPESPACE_DEFINE_DETAILS> RULE_DEVICE_TYPESPACE_DEFINE_DETAILS { get; set; }
        public DbSet<RULE_DEVICE_TYPESPACE_MODEL> RULE_DEVICE_TYPESPACE_MODEL { get; set; }
        public DbSet<YBK_DEVICE_ENTITY_INFORMATION> YBK_DEVICE_ENTITY_INFORMATION { get; set; }
        public DbSet<YBK_DEVICE_INFORMATION> YBK_DEVICE_INFORMATION { get; set; }
        public DbSet<YBK_DEVICE_INFORMATION_PICTURE> YBK_DEVICE_INFORMATION_PICTURE { get; set; }
        public DbSet<YBK_DEVICE_OBJECT_INFORMATION> YBK_DEVICE_OBJECT_INFORMATION { get; set; }
        public DbSet<YBK_DEVICE_SPACEUSE_INDEX> YBK_DEVICE_SPACEUSE_INDEX { get; set; }
        public DbSet<YBK_DEVICE_SPACEUSE_INFORMATION> YBK_DEVICE_SPACEUSE_INFORMATION { get; set; }
        public DbSet<YBK_PATIENT_CARD> YBK_PATIENT_CARD { get; set; }
        public DbSet<YBK_PATIENT_MEDICAL_RECORD> YBK_PATIENT_MEDICAL_RECORD { get; set; }
        public DbSet<YBK_PATIENT_PATIENTINFO> YBK_PATIENT_PATIENTINFO { get; set; }
        public DbSet<YBK_PROJECT_INFORMATION> YBK_PROJECT_INFORMATION { get; set; }
        public DbSet<YBK_PROJECT_INFORMATION_CD> YBK_PROJECT_INFORMATION_CD { get; set; }
        public DbSet<YBK_QUESTIONNAIRE> YBK_QUESTIONNAIRE { get; set; }
        public DbSet<YBK_QUESTIONNAIRE_ATTRIBUTE> YBK_QUESTIONNAIRE_ATTRIBUTE { get; set; }
        public DbSet<YBK_QUESTIONNAIRE_ATTRIBUTE_CODOMAIN> YBK_QUESTIONNAIRE_ATTRIBUTE_CODOMAIN { get; set; }
        public DbSet<YBK_QUESTIONNAIRE_CASE> YBK_QUESTIONNAIRE_CASE { get; set; }
        public DbSet<YBK_QUESTIONNAIRE_CASE_SUBJECT> YBK_QUESTIONNAIRE_CASE_SUBJECT { get; set; }
        public DbSet<YBK_QUESTIONNAIRE_RESULT> YBK_QUESTIONNAIRE_RESULT { get; set; }
        public DbSet<YBK_QUESTIONNAIRE_SUBJECT> YBK_QUESTIONNAIRE_SUBJECT { get; set; }
        public DbSet<YBK_SAMPLE_APPLICATION> YBK_SAMPLE_APPLICATION { get; set; }
        public DbSet<YBK_SAMPLE_APPLICATION_DELIVERY> YBK_SAMPLE_APPLICATION_DELIVERY { get; set; }
        public DbSet<YBK_SAMPLE_APPLICATION_DELIVERY_CD> YBK_SAMPLE_APPLICATION_DELIVERY_CD { get; set; }
        public DbSet<YBK_SAMPLE_APPLICATION_DELIVERY_DETAILS> YBK_SAMPLE_APPLICATION_DELIVERY_DETAILS { get; set; }
        public DbSet<YBK_SAMPLE_APPLICATION_DETAILS> YBK_SAMPLE_APPLICATION_DETAILS { get; set; }
        public DbSet<YBK_SAMPLE_BARCODE_BATCH> YBK_SAMPLE_BARCODE_BATCH { get; set; }
        public DbSet<YBK_SAMPLE_BARCODE_INFORMATION> YBK_SAMPLE_BARCODE_INFORMATION { get; set; }
        public DbSet<YBK_SAMPLE_INFORMATION> YBK_SAMPLE_INFORMATION { get; set; }
        public DbSet<YBK_SAMPLE_INFORMATION_CD> YBK_SAMPLE_INFORMATION_CD { get; set; }
        public DbSet<YBK_SAMPLE_OPERATION_BASE> YBK_SAMPLE_OPERATION_BASE { get; set; }
        public DbSet<YBK_SAMPLE_OPERATION_DETAILS> YBK_SAMPLE_OPERATION_DETAILS { get; set; }
        public DbSet<YBK_SAMPLE_PIPE_INFO> YBK_SAMPLE_PIPE_INFO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DIC_DEPARTMENTMap());
            modelBuilder.Configurations.Add(new DIC_DEVICE_TYPEMap());
            modelBuilder.Configurations.Add(new DIC_GENERALMap());
            modelBuilder.Configurations.Add(new DIC_PRACTITIONERMap());
            modelBuilder.Configurations.Add(new DIC_SAMPLE_DEALMap());
            modelBuilder.Configurations.Add(new DIC_SAMPLE_ORGANMap());
            modelBuilder.Configurations.Add(new DIC_SAMPLE_TYPEMap());
            modelBuilder.Configurations.Add(new DIC_SAMPLE_TYPE_bakMap());
            modelBuilder.Configurations.Add(new DIC_SPACE_TYPEMap());
            modelBuilder.Configurations.Add(new INTERFACE_HIS_PATIENT_INFOMap());
            modelBuilder.Configurations.Add(new RULE_BH_MAKEMap());
            modelBuilder.Configurations.Add(new RULE_DEVICE_NUMBERMap());
            modelBuilder.Configurations.Add(new RULE_DEVICE_TPYESPACE_LOCATIONMap());
            modelBuilder.Configurations.Add(new RULE_DEVICE_TPYESPACE_RELATIONMap());
            modelBuilder.Configurations.Add(new RULE_DEVICE_TYPESPACE_DEFINEMap());
            modelBuilder.Configurations.Add(new RULE_DEVICE_TYPESPACE_DEFINE_DETAILSMap());
            modelBuilder.Configurations.Add(new RULE_DEVICE_TYPESPACE_MODELMap());
            modelBuilder.Configurations.Add(new YBK_DEVICE_ENTITY_INFORMATIONMap());
            modelBuilder.Configurations.Add(new YBK_DEVICE_INFORMATIONMap());
            modelBuilder.Configurations.Add(new YBK_DEVICE_INFORMATION_PICTUREMap());
            modelBuilder.Configurations.Add(new YBK_DEVICE_OBJECT_INFORMATIONMap());
            modelBuilder.Configurations.Add(new YBK_DEVICE_SPACEUSE_INDEXMap());
            modelBuilder.Configurations.Add(new YBK_DEVICE_SPACEUSE_INFORMATIONMap());
            modelBuilder.Configurations.Add(new YBK_PATIENT_CARDMap());
            modelBuilder.Configurations.Add(new YBK_PATIENT_MEDICAL_RECORDMap());
            modelBuilder.Configurations.Add(new YBK_PATIENT_PATIENTINFOMap());
            modelBuilder.Configurations.Add(new YBK_PROJECT_INFORMATIONMap());
            modelBuilder.Configurations.Add(new YBK_PROJECT_INFORMATION_CDMap());
            modelBuilder.Configurations.Add(new YBK_QUESTIONNAIREMap());
            modelBuilder.Configurations.Add(new YBK_QUESTIONNAIRE_ATTRIBUTEMap());
            modelBuilder.Configurations.Add(new YBK_QUESTIONNAIRE_ATTRIBUTE_CODOMAINMap());
            modelBuilder.Configurations.Add(new YBK_QUESTIONNAIRE_CASEMap());
            modelBuilder.Configurations.Add(new YBK_QUESTIONNAIRE_CASE_SUBJECTMap());
            modelBuilder.Configurations.Add(new YBK_QUESTIONNAIRE_RESULTMap());
            modelBuilder.Configurations.Add(new YBK_QUESTIONNAIRE_SUBJECTMap());
            modelBuilder.Configurations.Add(new YBK_SAMPLE_APPLICATIONMap());
            modelBuilder.Configurations.Add(new YBK_SAMPLE_APPLICATION_DELIVERYMap());
            modelBuilder.Configurations.Add(new YBK_SAMPLE_APPLICATION_DELIVERY_CDMap());
            modelBuilder.Configurations.Add(new YBK_SAMPLE_APPLICATION_DELIVERY_DETAILSMap());
            modelBuilder.Configurations.Add(new YBK_SAMPLE_APPLICATION_DETAILSMap());
            modelBuilder.Configurations.Add(new YBK_SAMPLE_BARCODE_BATCHMap());
            modelBuilder.Configurations.Add(new YBK_SAMPLE_BARCODE_INFORMATIONMap());
            modelBuilder.Configurations.Add(new YBK_SAMPLE_INFORMATIONMap());
            modelBuilder.Configurations.Add(new YBK_SAMPLE_INFORMATION_CDMap());
            modelBuilder.Configurations.Add(new YBK_SAMPLE_OPERATION_BASEMap());
            modelBuilder.Configurations.Add(new YBK_SAMPLE_OPERATION_DETAILSMap());
            modelBuilder.Configurations.Add(new YBK_SAMPLE_PIPE_INFOMap());
        }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
