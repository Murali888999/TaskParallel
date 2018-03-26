using System;
using System.Threading;

namespace TaskParellel
{
    class Thread3
    {
        public void test()
        {
            for(int i =0;i<10;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
            for (int i = 10; i < 20; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class ThreawithSleep
    {
        static void Main(string[] args)
        {
           
            Thread3 obj = new Thread3();
            Thread t = new Thread(new ThreadStart(obj.test));
            t.Start();
            Console.Read();
        }
    }
}
