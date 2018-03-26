using System;
using System.Threading.Tasks;
using System.Threading;
using log4net;
using log4net.Config;
namespace TaskParellel
{
    class TaskFactoryMethod
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(TaskFactoryMethod));
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            Task t = Task.Factory.StartNew(() =>
             {
                 Console.WriteLine("task");
             });
            Console.WriteLine(Thread.CurrentThread.Name);
            t.Wait();
            Console.Read();
        }
    }
}