using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart start = new ThreadStart(Counting);
            Thread firstThread = new Thread(start);
            Thread secondThread = new Thread(start);

            firstThread.Start();
            secondThread.Start();

            firstThread.Join();
            secondThread.Join();

            Console.ReadKey();
        }

        static void Counting()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"Current count: {i}");
                Console.WriteLine($" - Current thread: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            }
        }
    }
}
