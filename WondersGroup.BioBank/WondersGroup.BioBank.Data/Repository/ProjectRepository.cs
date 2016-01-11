using WondersGroup.BioBank.Data.Infrastructure;
using WondersGroup.BioBank.Model.Models;

namespace WondersGroup.BioBank.Data.Repository
{
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
   
}
