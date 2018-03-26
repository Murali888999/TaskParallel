using System;
using System.Threading;
using log4net.Config;
using log4net;

namespace TaskParellel
{
    class Thread7
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Thread7));
        public void Test()
        {
            lock (this)
            {
                for(int i = 0; i < 10; i++)
                {
                    Thread.Sleep(1000);
                    log.Info(i);
                }
            }
        }
    }
    class Synchronization
    {
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            Thread7 obj = new Thread7();
            Thread t = new Thread(new ThreadStart(obj.Test));
            Thread t1 = new Thread(new ThreadStart(obj.Test));
            t.Start();
            t1.Start();
            Console.Read();
        }
    }
}