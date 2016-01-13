using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WondersGroup.BioBank.Data.Repository;
using WondersGroup.BioBank.Model.Models;
using WondersGroup.BioBank.Service;
using WondersGroup.BioBank.Data.Infrastructure;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectTest.Test();
        }
    }

    public static class ProjectTest
    {
        public static void Test()
        {
            Console.WriteLine("in");

            DatabaseFactory factory = new DatabaseFactory();

            IProjectService service = new ProjectService(new ProjectInfomationRepository(factory), new ProjectInfomationCDRepository(factory), new UnitOfWork(factory));

            IEnumerable<YBK_PROJECT_INFORMATION> result = service.GetAll();

            Console.WriteLine(result.Count());
        }
    }
}
