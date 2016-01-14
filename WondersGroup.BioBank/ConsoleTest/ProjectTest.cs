using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WondersGroup.BioBank.Data.Infrastructure;
using WondersGroup.BioBank.Data.Repository;
using WondersGroup.BioBank.Model.Models;
using WondersGroup.BioBank.Service;

namespace ConsoleTest
{
    public static class ProjectTest
    {
        public static void TestGetProjectByCondition()
        {
            Console.WriteLine("in TestGetProjectByCondition");

            DatabaseFactory factory = new DatabaseFactory();

            IProjectService service = new ProjectService(new ProjectInfomationRepository(factory), new ProjectInfomationCDRepository(factory), new UnitOfWork(factory));

            Page p = new Page(1, 10);

            IPagedList<YBK_PROJECT_INFORMATION> result = service.GetProjectByCondition(p, "", "", "3");

            foreach (YBK_PROJECT_INFORMATION item in result)
            {
                Console.WriteLine("项目名称:" + item.XMMC);
            }
            Console.WriteLine("总行数:" + result.TotalItemCount);
        }
    }
}
