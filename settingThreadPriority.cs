using System;
using System.Threading;
using log4net;
using log4net.Config;

namespace TaskParellel
{
    class priority
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(priority));
        public   void Pawan()
        {
            Thread tt = Thread.CurrentThread;
            log.Info(tt.Name + " :runnig");
        }
    }
    class settingThreadPriority
    {
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            priority p = new priority();
            Thread t1 = new Thread(new ThreadStart(p.Pawan));
            Thread t2 = new Thread(new ThreadStart(p.Pawan));
            Thread t3 = new Thread(new ThreadStart(p.Pawan));
            t1.Name = "Thread1";
            t2.Name = "Thread2";
            t3.Name = "Thread3";
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Normal;
            t3.Priority = ThreadPriority.Lowest;
            t1.Start();
            t2.Start();
            t3.Start();
           
            Console.Read();

        }
    }
}

