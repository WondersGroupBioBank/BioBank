using WondersGroup.BioBank.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WondersGroup.BioBank.Data.Infrastructure;
using WondersGroup.BioBank.Model.Models;

namespace WondersGroup.BioBank.Service
{
    public interface IProjectService
    {
        void CommitProjectInfo();

        IEnumerable<YBK_PROJECT_INFORMATION> GetAll();

        void AddProjectInfo(YBK_PROJECT_INFORMATION pro, List<YBK_PROJECT_INFORMATION_CD> cdlst);
    }

    public class ProjectService: IProjectService
    {
        private readonly IProjectInfomationRepository projectInfoRepository;
        private readonly IProjectInfomationCDRepository projectCdRepository;

        
        private readonly IUnitOfWork unitOfWork;

        public ProjectService(IProjectInfomationRepository projectInfoRepository, IProjectInfomationCDRepository projectCdRepository,IUnitOfWork unitOfWork)
        {
            this.projectInfoRepository = projectInfoRepository;
            this.projectCdRepository = projectCdRepository;
            this.unitOfWork = unitOfWork;
        }


        public void AddProjectInfo(YBK_PROJECT_INFORMATION pro, List<YBK_PROJECT_INFORMATION_CD> cdlst)
        {
            if(pro == null)
            {
                throw new Exception("pro is Null");
            }

            projectInfoRepository.Add(pro);

            foreach(var item in cdlst)
            {
                item.XMID = pro.XMID;
                projectCdRepository.Add(item);
            }
           
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
