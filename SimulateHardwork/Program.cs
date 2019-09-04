namespace SimulateHardwork
{
    using System;
    using System.Collections.Concurrent;
    using System.Diagnostics;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            var timesLooped = 10000;

            var sw = new Stopwatch();
            sw.Start();
            SequentialLoop(timesLooped);
            sw.Stop();

            var sw2 = new Stopwatch();
            sw2.Start();
            ParallelLoop(timesLooped);
            sw2.Stop();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Sequential loop elapsed time: {0}", sw.ElapsedMilliseconds);
            Console.WriteLine("Parallel loop elapsed time: {0}", sw2.ElapsedMilliseconds);
            Console.ReadKey();
        }

        static void ParallelLoop(int timesLooped)
        {
            Parallel.For(1, timesLooped + 1, Console.WriteLine);
        }

        static void SequentialLoop(int timesLooped)
        {
            for (var i = 1; i <= timesLooped; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
