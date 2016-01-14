using WondersGroup.BioBank.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WondersGroup.BioBank.Data.Infrastructure;
using WondersGroup.BioBank.Model.Models;
using PagedList;

namespace WondersGroup.BioBank.Service
{
    public interface IProjectService
    {
        void CommitProjectInfo();

        /// <summary>
        /// 插入项目信息
        /// </summary>
        /// <param name="pro"></param>
        /// <param name="cdlst"></param>
        void AddProjectInfo(YBK_PROJECT_INFORMATION pro, List<YBK_PROJECT_INFORMATION_CD> cdlst);

        /// <summary>
        /// 更新项目信息
        /// </summary>
        /// <param name="pro"></param>
        /// <param name="cdlst"></param>
        void UpdateProjectInfo(YBK_PROJECT_INFORMATION pro, List<YBK_PROJECT_INFORMATION_CD> cdlst);

        /// <summary>
        /// 删除项目信息
        /// </summary>
        /// <param name="xmid"></param>
        void DeleteProjectInfo(string xmid);

        /// <summary>
        /// 提交项目申请
        /// </summary>
        /// <param name="xmid"></param>
        void CommitProjectInfo(string xmid);

        /// <summary>
        /// 完成项目申请
        /// </summary>
        /// <param name="xmid"></param>
        void FinishProjectInfo(string xmid);

        /// <summary>
        /// 审核项目申请
        /// </summary>
        /// <param name="xmid"></param>
        void AuditProjectInfo(string xmid);

        /// <summary>
        /// 根据ID获取项目
        /// </summary>
        /// <param name="xmid"></param>
        /// <returns></returns>
        YBK_PROJECT_INFORMATION GetProjectByID(string xmid);

        /// <summary>
        /// 根据条件获取项目列表
        /// </summary>
        /// <param name="ktbh">课题编号</param>
        /// <param name="xmmc">项目名称</param>
        /// <param name="xmzt">项目状态</param>
        /// <returns></returns>
        IPagedList<YBK_PROJECT_INFORMATION> GetProjectByCondition(Page page, string ktbh, string xmmc, string xmzt);
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

        /// <summary>
        /// 插入项目信息
        /// </summary>
        /// <param name="pro"></param>
        /// <param name="cdlst"></param>
        public void AddProjectInfo(YBK_PROJECT_INFORMATION pro, List<YBK_PROJECT_INFORMATION_CD> cdlst)
        {
            if(pro == null)
            {
                throw new Exception("pro is Null");
            }

            projectInfoRepository.Add(pro);
            CommitProjectInfo();

            foreach (var item in cdlst)
            {
                item.XMID = pro.XMID;
                projectCdRepository.Add(item);
            }
           
            CommitProjectInfo();
        }

        /// <summary>
        /// 更新项目信息
        /// </summary>
        /// <param name="pro"></param>
        /// <param name="cdlst"></param>
        public void UpdateProjectInfo(YBK_PROJECT_INFORMATION pro, List<YBK_PROJECT_INFORMATION_CD> cdlst)
        {

        }

        /// <summary>
        /// 删除项目信息
        /// </summary>
        /// <param name="xmid"></param>
        public void DeleteProjectInfo(string xmid)
        {
            if(string.IsNullOrEmpty(xmid))
            {
                throw new Exception("xmid is null");
            }
            var comment = projectInfoRepository.GetById(xmid);
            projectInfoRepository.Delete(comment);
            CommitProjectInfo();
        }

        /// <summary>
        /// 提交项目申请
        /// </summary>
        /// <param name="xmid"></param>
        public void CommitProjectInfo(string xmid)
        {
            if (string.IsNullOrEmpty(xmid))
            {
                throw new Exception("xmid is null");
            }
            var comment = projectInfoRepository.GetById(xmid);
            comment.XMZT = "2";
            projectInfoRepository.Update(comment);
            CommitProjectInfo();
        }

        /// <summary>
        /// 完成项目申请
        /// </summary>
        /// <param name="xmid"></param>
        public void FinishProjectInfo(string xmid)
        {
            if (string.IsNullOrEmpty(xmid))
            {
                throw new Exception("xmid is null");
            }
            var comment = projectInfoRepository.GetById(xmid);
            comment.XMZT = "4";
            projectInfoRepository.Update(comment);
            CommitProjectInfo();
        }

        /// <summary>
        /// 审核项目申请
        /// </summary>
        /// <param name="xmid"></param>
        public void AuditProjectInfo(string xmid)
        {
            if (string.IsNullOrEmpty(xmid))
            {
                throw new Exception("xmid is null");
            }
            var comment = projectInfoRepository.GetById(xmid);
            comment.XMZT = "3";
            projectInfoRepository.Update(comment);
            CommitProjectInfo();
        }

        /// <summary>
        /// 根据ID获取项目
        /// </summary>
        /// <param name="xmid"></param>
        /// <returns></returns>
        public YBK_PROJECT_INFORMATION GetProjectByID(string xmid)
        {
            if (string.IsNullOrEmpty(xmid))
            {
                throw new Exception("xmid is null");
            }
            var comment = projectInfoRepository.GetById(xmid);
            return comment;
        }

        /// <summary>
        /// 根据条件获取项目列表
        /// </summary>
        /// <param name="ktbh">课题编号</param>
        /// <param name="xmmc">项目名称</param>
        /// <param name="xmzt">项目状态</param>
        /// <returns></returns>
        public IPagedList<YBK_PROJECT_INFORMATION> GetProjectByCondition(Page page,string ktbh,string xmmc,string xmzt)
        {
            if (page == null)
            {
                throw new Exception("page is null");
            }
            return projectInfoRepository.GetPage(page, where =>  where.XMZT == xmzt && where.KTBH.Contains(ktbh) && where.XMMC.Contains(xmmc) && where.SJZT == "1", order => order.XMID);
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
