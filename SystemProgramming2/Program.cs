using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SystemProgramming2
{
    internal class Program
    {
        //const int totalcount = 100_000_000;
        //static void TestThread()
        //{
        //    Console.WriteLine("Start TestThread");
        //    for (int i = 0; i < 20; i++)
        //    {
        //        i++;
        //        Console.WriteLine(i);
        //        Thread.Sleep(500);
        //    }
        //    Console.WriteLine("Finish TestThread");
        //}
        //static ConcurrentQueue<Order> orders = new ConcurrentQueue<Order>();
        //static void ProcessOrder()
        //{
        //    while (true)
        //    {
        //        if (orders.TryDequeue(out Order order))
        //        {
        //            Console.WriteLine(
        //            $"Worker {Thread.CurrentThread.ManagedThreadId} processing the order {order.Id}: {order.ProductName}");
        //            Thread.Sleep(500);
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
         
        //}
        [DllImport("PointManager.dll")]
        public static extern IntPtr CreatePointManager();

        [DllImport("PointManager.dll")]
        public static extern void DestroyPointManager(IntPtr pm);

        [DllImport("PointManager.dll")]
        public static extern void PointManager_AddPoint(IntPtr pm, int x, int y);

        [DllImport("PointManager.dll")]
        public static extern void PointManager_RemovePoint(IntPtr pm, int index);

        [DllImport("PointManager.dll")]
        public static extern void PointManager_GetPoint(IntPtr pm, int index, out int x, out int y);

        [DllImport("PointManager.dll")]
        public static extern int PointManager_Count(IntPtr pm);
        static void Main(string[] args)
        {
            IntPtr pm = CreatePointManager();

            PointManager_AddPoint(pm, 10, 20);
            PointManager_AddPoint(pm, 30, 40);

            int count = PointManager_Count(pm);
            Console.WriteLine($"Count: {count}");

            for (int i = 0; i < count; i++)
            {
                PointManager_GetPoint(pm, i, out int x, out int y);
                Console.WriteLine($"Point {i}: ({x}, {y})");
            }

            PointManager_RemovePoint(pm, 0);

            Console.WriteLine($"Count after remove: {PointManager_Count(pm)}");

            DestroyPointManager(pm);
            //BankAccount account = new BankAccount();
            //account.Replenishment(500);
            //Console.WriteLine(account.Cash);
            //ManualResetEvent done = new ManualResetEvent(false);
            //Console.WriteLine("Start main");
            //ThreadPool.QueueUserWorkItem(_ =>
            //{
            //    Console.WriteLine("Thread start");
            //    Thread.Sleep(500);
            //    Console.WriteLine("Thread finish");
            //});
            //done.WaitOne();
            //Console.WriteLine("End main");
            //for (int i = 1; i <= 10; i++)
            //{
            //    orders.Enqueue(new Order
            //    {
            //        Id = i,
            //        ProductName = $"Product_{i}"
            //    });
            //}
            //Thread[] workers = new Thread[3];
            //for (int i = 0; i < workers.Length; i++)
            //{
            //    workers[i] = new Thread(ProcessOrder);
            //    workers[i].Start();
            //}
            // Исправлено: создание экземпляра ProcessDemo и передача метода Run в Thread
            //Thread thread = new Thread(new ProcessDemo().Run);
            //thread.Start();
            //var processes = Process.GetProcesses();
            //string fileName = $"processes_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.txt";
            //string path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            //using (StreamWriter writer = new StreamWriter(path))
            //{
            //    foreach(var process in processes)
            //    {
            //        try
            //        {
            //            writer.WriteLine($"Name: {process.ProcessName} | ID: {process.Id}");
            //        }
            //        catch 
            //        {
            //            writer.WriteLine("Access denied process");
            //        }
            //    }
            //}
            //thread.Join();
            //Console.WriteLine($"File created: {path}");
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
