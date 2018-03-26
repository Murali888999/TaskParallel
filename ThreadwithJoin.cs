using System;
using System.Threading;

namespace TaskParellel
{
    class Thread5
        {
            public static void power()
            {
                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine(i);
                Thread.Sleep(2000);
            }
            }
        }
        class ThreadwithJoin
        {
            static void Main(string[] args)
            {
                Console.WriteLine("start of Main");
                Thread t1 = new Thread(new ThreadStart(Thread5.power));
                Thread t2 = new Thread(new ThreadStart(Thread5.power));
                t1.Start();
                t1.Join();
                t2.Start();
                Console.WriteLine("very good morning");
                Console.WriteLine("end of main");
                Console.Read();
            }
        }
 }


