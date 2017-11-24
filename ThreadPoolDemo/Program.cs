using System;
using System.Threading;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitCallback callback = new WaitCallback(ShowMyText);
            ThreadPool.QueueUserWorkItem(callback, "The ");
            ThreadPool.QueueUserWorkItem(callback, "harder ");
            ThreadPool.QueueUserWorkItem(callback, "I ");
            ThreadPool.QueueUserWorkItem(callback, "work ");
            ThreadPool.QueueUserWorkItem(callback, "the ");
            ThreadPool.QueueUserWorkItem(callback, "luckier ");
            ThreadPool.QueueUserWorkItem(callback, "I ");
            ThreadPool.QueueUserWorkItem(callback, "become ");
            Console.ReadKey();

        }

        static void ShowMyText(object state)
        {
            string stateString = $"State: {(string)state}";
            string threadString = $"Thread: {Thread.CurrentThread.ManagedThreadId}";
            Console.WriteLine(stateString + threadString);
        }
    }
}
