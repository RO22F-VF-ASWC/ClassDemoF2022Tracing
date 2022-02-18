using System;

namespace ClassDemoF2022Tracing
{
    class Program
    {
        static void Main(string[] args)
        {
            AWorker worker = new AWorker();
            worker.Start();

            Console.WriteLine("Hello World!");
        }
    }
}
