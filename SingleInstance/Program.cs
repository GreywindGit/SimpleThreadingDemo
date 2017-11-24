using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SingleInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex mutex = null;
            const string mutexName = "RUNMEONLYONCE";

            while (true)
            {
                try
                {
                    mutex = Mutex.OpenExisting(mutexName);
                    Console.WriteLine("Mutex found, exiting.");
                    mutex.Close();
                    break;
                }
                catch (WaitHandleCannotBeOpenedException)
                {
                    mutex = new Mutex(true, mutexName);
                    Console.WriteLine("Mutex not found, created.");
                }
            }
            Console.ReadKey();
        }
    }
}
