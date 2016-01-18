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

        public static void TestAddProject()
        {
            Console.WriteLine("in TestAddProject");

            DatabaseFactory factory = new DatabaseFactory();

            IProjectService service = new ProjectService(new ProjectInfomationRepository(factory), new ProjectInfomationCDRepository(factory), new UnitOfWork(factory));

            YBK_PROJECT_INFORMATION proInfo = new YBK_PROJECT_INFORMATION
            {
                BLZD = "诊断",
                BZ = "备注",
                XMMC = "测试项目",
                CJSJ = DateTime.Now,
                CJYID = 1,
                CJYXM = "",
                EJGLXYSFXS = "1",
                GDZZSLYB = "1",
                HZDW = "单位",
                HZRXM = "合作人AA",
                KTBH = "Pro001",
                KTLLRGH = "001",
                KTLLRID = 1,
                KTLLRXM = "联络人A",
                KTQSSJ = DateTime.Now,
                LXDH = "13011111111",
                NY = 0,
                QTLXYBSM = "",
                SJZT = "1",
                SPRGH = "001",
                SPRID = 1,
                SPRXM = "",
                SPSJ = DateTime.Now,
                SPWTGYY = "",
                SSJE = 1000,
                SSKS = 1,
                SSKSMC = "111",
                WZXFKN = 0,
                WZXKN = 0,
                WZXKNLXEDTA = "1",
                WZXKNLXGS = "1",
                WZXKNLXGYSN = "1",
                WZXKNLXQT = "1",
                WZXKNLXQTMC = "test",
                XMFZRGH = "001",
                XMFZRID = 1,
                XMFZRXM = "xm",
                XMZCY = "123",
                XMZT = "1",
                XXZZDCYB = "1",
                YBLX_NY = "1",
                YBLX_QT = "1",
                YBLX_QTMC = "",
                YBLX_XY = "1",
                YBLX_ZZ = "1",
                YBSYHJGFK = "",
                YJFASJLX_GCXYJ = "1",
                YJFASJLX_HGXFX = "1",
                YJFASJLX_QZXFX = "1",
                YJFASJLX_SYXYJ = "1",
                ZJCZSJ = DateTime.Now,
                ZJCZYID = 1,
                ZJCZYXM = "xm",
                ZJLY = "1",
                ZJLYMC = "科室",
                ZZYBCJFS_HJ = "1",
                ZZYBCJFS_SS = "1"
            };

            List<YBK_PROJECT_INFORMATION_CD> lst = new List<YBK_PROJECT_INFORMATION_CD>();
            YBK_PROJECT_INFORMATION_CD cd1 = new YBK_PROJECT_INFORMATION_CD
            {
                CJSJ = DateTime.Now,
                CJYID = 1,
                CJYXM = "xm",
                SJZT = "1",
                XMID = proInfo.XMID,
                YBLCZD = "风寒",
                YBLCZDMC = "风寒",
                ZJCZSJ = DateTime.Now,
                ZJCZYID = 1,
                ZJCZYXM = "xm"
            };

            YBK_PROJECT_INFORMATION_CD cd2 = new YBK_PROJECT_INFORMATION_CD
            {
                CJSJ = DateTime.Now,
                CJYID = 1,
                CJYXM = "xm",
                SJZT = "1",
                XMID = proInfo.XMID,
                YBLCZD = "感冒",
                YBLCZDMC = "感冒",
                ZJCZSJ = DateTime.Now,
                ZJCZYID = 1,
                ZJCZYXM = "xm"
            };

            lst.Add(cd1);
            lst.Add(cd2);
            service.AddProjectInfo(proInfo, lst);
            Console.WriteLine("SUCC");


        }
    }
}
