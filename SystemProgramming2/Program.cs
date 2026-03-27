using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.Json;
using System.Threading.Tasks;

namespace SystemProgramming2
{
    //class Currency
    //{
    //    public int r030 { get; set; }
    //    public string txt { get; set; }
    //    public decimal rate { get; set; }
    //    public override string ToString()
    //    {
    //        return $"Currency: {txt}| Rate: {rate}";
    //    }
    //}
    internal class Program
    {
        const int N = 20;
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
        //[DllImport("PointManager.dll")]
        //public static extern IntPtr CreatePointManager();

        //[DllImport("PointManager.dll")]
        //public static extern void DestroyPointManager(IntPtr pm);

        //[DllImport("PointManager.dll")]
        //public static extern void PointManager_AddPoint(IntPtr pm, int x, int y);

        //[DllImport("PointManager.dll")]
        //public static extern void PointManager_RemovePoint(IntPtr pm, int index);

        //[DllImport("PointManager.dll")]
        //public static extern void PointManager_GetPoint(IntPtr pm, int index, out int x, out int y);

        //[DllImport("PointManager.dll")]
        //public static extern int PointManager_Count(IntPtr pm);
        //static async Task<List<Document>> DownloadDocuments ()
        //{
        //    var documents = new List<Document>();
        //    Console.WriteLine("Request received");
        //    Console.WriteLine("Getting documents...");
        //    var doc1 = new Document { Name = "Doc" , Number = 1};
        //    documents.Add(doc1);
        //    await Task.Delay (1000);
        //    Console.WriteLine("Getting documents...");
        //    var doc2 = new Document { Name = "Doc", Number = 2 };
        //    documents.Add(doc2);
        //    await Task.Delay(1000);
        //    Console.WriteLine("Getting documents...");
        //    var doc3 = new Document { Name = "Doc", Number = 3 };
        //    documents.Add(doc3);
        //    await Task.Delay(1000);
        //    Console.WriteLine("Documents received");
        //    return documents;
        //}
        //private static readonly string _url = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json";
        //static async Task<List<Currency>> GetCurrencyAsync()
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        try
        //        {
        //            var response = await client.GetStringAsync(_url);
        //            var obj = JsonSerializer.Deserialize<List<Currency>>(response);
        //            if (obj != null)
        //            {
        //                return obj;
        //            }
        //        }
        //        catch (Exception)
        //        {

        //        }
        //        return null;
        //    }
        //}
        //static async Task<Pizza> DoPizza()
        //{
        //    Console.WriteLine("Receive an order");
        //    Console.WriteLine("Start cooking");
        //    await Task.Delay(500);
        //    Console.WriteLine("Making dough");
        //    await Task.Delay(1000);
        //    Console.WriteLine("Making filling");
        //    Console.WriteLine("Bake pizza");
        //    return new Pizza { Name = "Margarita", Price = 200 };
        //}
        //static async Task<decimal> ConvertationAsync(decimal amount)
        //{
        //    var data = await GetCurrencyAsync();
        //    decimal result = 0;
        //    if (data != null) {
        //        foreach (var item in data)
        //        {
        //            if (item.r030 == 840)
        //            {
        //                result = amount / item.rate;
        //            }
        //        }
        //    }
        //    return result;
        //}
        static void PrintLow()
        {
            for (int i = 0; i < N; i++)
            {
                
                Console.WriteLine("Low");
                Thread.Sleep(100);
            }
        }
        static void PrintMedium()
        {
            for (int i = 0; i < N; i++)
            {
                
                Console.WriteLine("Medium");
                Thread.Sleep(100);
            }
        }
        static void PrintHigh()
        {
            for (int i = 0; i < N; i++)
            {
                
                Console.WriteLine("High");
                Thread.Sleep(100);
            }
        }
        static async Task Main(string[] args)
        {
            Thread threadlow = new Thread(PrintLow);
            Thread threadmedium = new Thread(PrintMedium);
            Thread threadhigh = new Thread(PrintHigh);
            threadlow.Priority = ThreadPriority.Highest;
            threadmedium.Priority = ThreadPriority.Normal;
            threadhigh.Priority = ThreadPriority.Lowest;
            threadlow.Start();
            threadlow.Join();
            threadmedium.Start();
            threadmedium.Join();
            threadhigh.Start();
            threadhigh.Join();
            //Console.WriteLine("Enter amount: ");
            //var t = Console.ReadLine();
            //decimal amount = decimal.Parse(t);
            //var result = ConvertationAsync(amount);
            //Console.WriteLine(result.Result); 
            //var data = await GetCurrencyAsync();
            //if (data != null)
            //{
            //    foreach (var item in data)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Making request");
            //var document = DownloadDocuments ();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("We are working");
            //    Thread.Sleep(1000);
            //}
            //document.Wait();
            //Console.WriteLine("Get documents");
            //foreach (var doc in document.Result)
            //{
            //    Console.WriteLine(doc);
            //}
            //Console.WriteLine("Making order pizza");
            //var pizza = DoPizza();
            //for (int i = 0; i < 10; i++) {
            //    Console.WriteLine("We are working");
            //    Thread.Sleep(1000);
            //}
            //pizza.Wait();
            //Console.WriteLine("Get pizza");
            //Console.WriteLine(pizza.Result);
            //IntPtr pm = CreatePointManager();

            //PointManager_AddPoint(pm, 10, 20);
            //PointManager_AddPoint(pm, 30, 40);

            //int count = PointManager_Count(pm);
            //Console.WriteLine($"Count: {count}");

            //for (int i = 0; i < count; i++)
            //{
            //    PointManager_GetPoint(pm, i, out int x, out int y);
            //    Console.WriteLine($"Point {i}: ({x}, {y})");
            //}

            //PointManager_RemovePoint(pm, 0);

            //Console.WriteLine($"Count after remove: {PointManager_Count(pm)}");

            //DestroyPointManager(pm);
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
        //public class Document
        //{
        //    public string Name { get; set; }
        //    public int Number { get; set; }
        //    public override string ToString()
        //    {
        //        return $"Name: {Name} | Number: {Number}";
        //    }
        //}
        //public class Pizza
        //{
        //    public string Name { get; set; }
        //    public int Price { get; set; }
        //    public override string ToString()
        //    {
        //        return $"Name: {Name} | Price: {Price}";
        //    }
        //}




    }
}
