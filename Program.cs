using System;
using System.Threading;

namespace MultithreadingApplication
{
    class ThreadCreationProgram
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            xcvb
        }
        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            for(int i=0;i<=5;i++)
            {
                Console.WriteLine(i);
            }
            Thread childThread = new Thread(childref);
            childThread.Start();
            Thread childThread1 = new Thread(childref);
            childThread1.Start();   
            Console.ReadKey();
        }

    }
    class demo
    {
        public static void CallToChildThread1()
        {
            Console.WriteLine("Child thread starts");

            // the thread is paused for 5000 milliseconds
            int sleepfor = 5000;
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }
    }
}