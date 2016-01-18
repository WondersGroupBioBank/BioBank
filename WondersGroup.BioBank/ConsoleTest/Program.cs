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
using WondersGroup.BioBank.Core.Common;
using Enyim.Caching;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProjectTest.TestGetProjectByCondition();
            // ProjectTest.TestAddProject();
            //LogHelper.SetConfig();
            //LogHelper.WriteLog("test");
            //LogHelper.WriteLog("testError",new Exception("errortest"));
            //MemcachedClient client = new MemcachedClient("enyim.com/memcached");
            //object name = client.Get("k11");
            //Console.WriteLine(name.ToString());
            testMemcachedProviders();

            MemcachedClient client = new MemcachedClient("enyim.com/memcached");
        }

        static void testMemcachedProviders()  
        {
            MemcachedClient client = new MemcachedClient("enyim.com/memcached");
            //存值  --不带过期时间的存储，Memcached将根据LRU来决定过期策略  
            bool result = client.Store(Enyim.Caching.Memcached.StoreMode.Add, "name", "dinglang");
            
            //带过期时间的缓存    
            //bool success = client.Store(StoreMode.Add, person.UserName, person, DateTime.Now.AddMinutes(10));   
            if (result)
            {
                Console.Write("成功存入缓存");

                //取值    
                object name = client.Get("name");
                if (name != null)
                {
                    Console.Write("取出的值为:" + name);
                }
                else
                {
                    Console.Write("取值失败");
                }
            }
            else
            {
                Console.Write("存入缓存失败");
            }
        }    
    }  
    
}
