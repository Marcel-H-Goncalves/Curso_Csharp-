using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mutex_e_Semaphore
{
    internal class Program
    {
        static Mutex mutexTask;
        static Semaphore semaphoreTask;

        static void MostrarMensagem(int numeroTask)
        {
            //mutexTask.WaitOne();
            semaphoreTask.WaitOne();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Número da task " + numeroTask + " . Número contador: " + i);
                Thread.Sleep(500);
            }
            semaphoreTask.Release();
            //mutexTask.ReleaseMutex();
        }

        static void Main(string[] args)
        {
            mutexTask = new Mutex();
            semaphoreTask = new Semaphore(2, 2);

            Task t1 = Task.Run(() => MostrarMensagem(1));
            Task t2 = Task.Run(() => MostrarMensagem(2));
            Task t3 = Task.Run(() => MostrarMensagem(3));
            Task t4 = Task.Run(() => MostrarMensagem(4));

            Console.ReadKey();

        }


    }
}