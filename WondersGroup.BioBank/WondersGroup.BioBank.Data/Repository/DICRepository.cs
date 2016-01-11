using WondersGroup.BioBank.Data.Infrastructure;
using WondersGroup.BioBank.Model.Models;

namespace WondersGroup.BioBank.Data.Repository
{

    #region 字典表_部门
    public class DicDeptmentRepository : RepositoryBase<DIC_DEPARTMENT>, IDicDeptmentRepository
    {
        public DicDeptmentRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }
    public interface IDicDeptmentRepository : IRepository<DIC_DEPARTMENT>
    {

    }
    #endregion  

    #region 字典表_设备类型
    public class DicDeviceTypeRepository : RepositoryBase<DIC_DEVICE_TYPE>, IDicDeviceTypeRepository
    {
        public DicDeviceTypeRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }
    public interface IDicDeviceTypeRepository : IRepository<DIC_DEVICE_TYPE>
    {

    }
    #endregion  

    #region 字典表_通用
    public class DicGeneralRepository : RepositoryBase<DIC_DEVICE_TYPE>, IDicGeneralRepository
    {
        public DicGeneralRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }
    public interface IDicGeneralRepository : IRepository<DIC_DEVICE_TYPE>
    {

    }
    #endregion  

    #region 字典表_通用
    public class DicPractitionneRepository : RepositoryBase<DIC_PRACTITIONER>, IDicPractitionneRepository
    {
        public DicPractitionneRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }
    public interface IDicPractitionneRepository : IRepository<DIC_PRACTITIONER>
    {

    }
    #endregion  

    #region 字典表_样本处理
    public class DicSampleDealRepository : RepositoryBase<DIC_SAMPLE_DEAL>, IDicSampleDealRepository
    {
        public DicSampleDealRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }
    public interface IDicSampleDealRepository : IRepository<DIC_SAMPLE_DEAL>
    {

    }
    #endregion  

    #region 字典表_样本器官
    public class DicSampleOrganRepository : RepositoryBase<DIC_SAMPLE_ORGAN>, IDicSampleOrganRepository
    {
        public DicSampleOrganRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }
    public interface IDicSampleOrganRepository : IRepository<DIC_SAMPLE_ORGAN>
    {

    }
    #endregion  

    #region 字典表_样本类型
    public class DicSampleTypeRepository : RepositoryBase<DIC_SAMPLE_TYPE>, IDicSampleTypeRepository
    {
        public DicSampleTypeRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }
    public interface IDicSampleTypeRepository : IRepository<DIC_SAMPLE_TYPE>
    {

    }
    #endregion  

    #region 字典表_空间类型
    public class DicSpaceTypeRepository : RepositoryBase<DIC_SPACE_TYPE>, IDicSpaceTypeRepository
    {
        public DicSpaceTypeRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }
    public interface IDicSpaceTypeRepository : IRepository<DIC_SPACE_TYPE>
    {

    }
    #endregion  

}