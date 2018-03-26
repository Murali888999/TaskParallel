using System;
using System.Threading;

namespace TaskParellel
{
    class Thread2
    {
        public void Lara()
        {
            for(int i=0;i<8;i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Tech()
        {
            for(int i=8;i<16;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class ThreadwithstaticandNonstatic
    {
        static void Main(string[] args)
        {
            Thread2 obj = new Thread2();
            Thread t = new Thread(new ThreadStart(obj.Lara));
            Thread t1 = new Thread(new ThreadStart(Thread2.Tech));
            t.Start();
            t1.Start();
            Console.Read();
        }
    }
}