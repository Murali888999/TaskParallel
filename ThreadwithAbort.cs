using System;
using System.Threading;

namespace TaskParellel
{
    class Thread4
    {
        public static void power()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
    }
    class ThreadwithAbort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start of Main");
            Thread t1 = new Thread(new ThreadStart(Thread4.power));
            Thread t2 = new Thread(new ThreadStart(Thread4.power));
            t1.Start();
            t2.Start();
            try
            {
                t1.Abort();
                t2.Abort();
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("end of main");
            Console.Read();
        }       
    }
}