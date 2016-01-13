using WondersGroup.BioBank.Data.Infrastructure;
using WondersGroup.BioBank.Model.Models;

namespace WondersGroup.BioBank.Data.Repository
{
    /// <summary>
    /// 项目仓储类
    /// </summary>
    public class ProjectInfomationRepository : RepositoryBase  <YBK_PROJECT_INFORMATION>, IProjectInfomationRepository
    {
        public ProjectInfomationRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
              
            }                   
    }
    public interface IProjectInfomationRepository : IRepository<YBK_PROJECT_INFORMATION>
    {

    }


    /// <summary>
    /// 项目诊断仓储类
    /// </summary>
    public class ProjectInfomationCDRepository : RepositoryBase<YBK_PROJECT_INFORMATION_CD>, IProjectInfomationCDRepository
    {
        public ProjectInfomationCDRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }
    public interface IProjectInfomationCDRepository : IRepository<YBK_PROJECT_INFORMATION_CD>
    {

    }

}
