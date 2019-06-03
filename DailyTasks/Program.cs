using System;
using System.Threading;

namespace DailyTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task();
            task1.Start();
            Console.WriteLine("Aloitetaan task1: " + task1.GetStartingTime().ToString());

            Console.WriteLine("Tauko 2000 ms");
            task1.Pause();
            //System.Threading.Tasks.Task.Delay(10000);
            Thread.Sleep(2000);

            Console.WriteLine("Jatketaan task1 2000 ms");
            task1.Continue();
            //System.Threading.Tasks.Task.Delay(10000);
            Thread.Sleep(2000);

            Console.WriteLine("Tauko 2000 ms");
            task1.Pause();
            //System.Threading.Tasks.Task.Delay(10000);
            Thread.Sleep(2000);

            Console.WriteLine("Jatketaan task1 2000 ms");
            task1.Continue();
            //System.Threading.Tasks.Task.Delay(10000);
            Thread.Sleep(2000);

            Console.WriteLine("Pysäytetään task1");
            task1.Stop();
            Console.WriteLine("task1 lopetusaika: " + task1.GetEndingTime().ToString());
            Console.WriteLine("Tehtävään käytetty aika sekunteina: " + task1.GetTimeUsed().TotalSeconds);
            Console.WriteLine("Taukoihin käytetty aika sekunteina: " + task1.GetBreaks().GetTotalTimeUsed().TotalSeconds);
            Console.WriteLine("Taukoja oli: " + task1.GetBreaks().GetTotalBreaks());

            Console.ReadKey();
        }
    }
}
