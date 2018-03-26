using log4net;
using System;
using System.Threading;
using log4net.Config;
namespace TaskParellel
{
    
    class Thread6
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Thread6));
        public static void Pawan()
        {
               Thread tt =Thread.CurrentThread;
               log.Info(tt.Name+ " :runnig");                          
        }
    }
    class SettingThreadName
    {

        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            Thread t1 = new Thread(new ThreadStart(Thread6.Pawan));
            Thread t2 = new Thread(new ThreadStart(Thread6.Pawan));
            Thread t3 = new Thread(new ThreadStart(Thread6.Pawan));
            t1.Name = "Thread1";
            t2.Name = "Thread2";
            t3.Name = "Thread3";
            t1.Start();
            t2.Start();
            t3.Start();
            Console.Read();

        }
    }
}
