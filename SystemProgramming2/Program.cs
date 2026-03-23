using System.Diagnostics;

namespace SystemProgramming2
{
    internal class Program
    {
        //const int totalcount = 100_000_000;
        static void TestThread()
        {
            Console.WriteLine("Start TestThread");
            for (int i = 0; i < 20; i++)
            {
                i++;
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
            Console.WriteLine("Finish TestThread");
        }
        static void Main(string[] args)
        {
            // Исправлено: создание экземпляра ProcessDemo и передача метода Run в Thread
            Thread thread = new Thread(new ProcessDemo().Run);
            thread.Start();
            var processes = Process.GetProcesses();
            string fileName = $"processes_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.txt";
            string path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach(var process in processes)
                {
                    try
                    {
                        writer.WriteLine($"Name: {process.ProcessName} | ID: {process.Id}");
                    }
                    catch 
                    {
                        writer.WriteLine("Access denied process");
                    }
                }
            }
            thread.Join();
            Console.WriteLine($"File created: {path}");

            //Thread.Sleep(5000);
            //Console.WriteLine("Cores: {0}", Environment.ProcessorCount);
            //Console.WriteLine("Start Main");
            //Console.WriteLine("Cores: {0}", Environment.ProcessorCount);
            //Thread thread = new Thread(TestThread);
            //thread.Start();
            //for (int i = 0;i < 20;i++)
            //    {
            //        Console.WriteLine(i);
            //        Thread.Sleep(1000);
            //    }
            //thread.Join();
            //Console.WriteLine("Finish Main");

        }
    }
}
