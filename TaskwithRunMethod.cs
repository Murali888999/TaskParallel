using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using log4net;
using log4net.Config;

namespace TaskParellel
{
    class TaskwithRunMethod
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Thread6));
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            Thread.CurrentThread.Name = "main:";
            Task t1 = Task.Run(() => { for (int i = 0; i < 10; i++) { Console.WriteLine(i); } });
            log.Info("hello from:" + Thread.CurrentThread.Name);
            t1.Wait();
            Console.Read();
        }
      
    }
}
