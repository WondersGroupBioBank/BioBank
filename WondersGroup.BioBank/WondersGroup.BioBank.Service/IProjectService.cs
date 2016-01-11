using WondersGroup.BioBank.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WondersGroup.BioBank.Data.Infrastructure;
using WondersGroup.BioBank.Model.Models;

namespace UnionLogin.Service
{
    public interface IProjectService
    {
        void CommitProjectInfo();

        IEnumerable<YBK_PROJECT_INFORMATION> GetAll();

        void AddProjectInfo(YBK_PROJECT_INFORMATION entity);
    }

    public class ProjectService: IProjectService
    {
        private readonly IProjectInfomationRepository projectInfoRepository;
        private readonly IUnitOfWork unitOfWork;

        public ProjectService(IProjectInfomationRepository projectInfoRepository, IUnitOfWork unitOfWork)
        {
            this.projectInfoRepository = projectInfoRepository;
            this.unitOfWork = unitOfWork;
        }

        public void AddProjectInfo(YBK_PROJECT_INFORMATION entity)
        {
            projectInfoRepository.Add(entity);


            CommitProjectInfo();
        }

        public IEnumerable<YBK_PROJECT_INFORMATION> GetAll()
        {
           return projectInfoRepository.GetAll();
        }

        public void CommitProjectInfo()
        {
            unitOfWork.Commit();
        }
    }
}
