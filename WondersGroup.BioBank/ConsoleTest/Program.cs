using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WondersGroup.BioBank.Data.Repository;
using WondersGroup.BioBank.Model.Models;
using WondersGroup.BioBank.Service;
using WondersGroup.BioBank.Data.Infrastructure;
using PagedList;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectTest.TestGetProjectByCondition();
        }
    }
}
