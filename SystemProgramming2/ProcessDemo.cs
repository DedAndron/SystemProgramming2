using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgramming2;

public class ProcessDemo
{
    public void Run()
    {
        ConsoleKeyInfo key;
        do
        {
            Console.WriteLine("Process Demo");
            Console.WriteLine("1 - Show All Processes Filter");
            Console.WriteLine("2 - Show All Processes");
            Console.WriteLine("3 - Get Process By Pid");
            Console.WriteLine("4 - Create Process");
            Console.WriteLine("5 - Kill Process");
            Console.WriteLine("6 - Call Test Programm");
            Console.WriteLine("7 - Open Browser");
            Console.WriteLine("0 - Exist");
            key = Console.ReadKey();
            switch (key.KeyChar)
            {
                case '1':
                    ShowAllProcessesFilter();
                    break;
                case '2':
                    ShowAllProcesses();
                    break;
                case '3':
                    GetProcessByPid();
                    break;
                case '4':
                    CreateProcess();
                    break;
                case '5':
                    KillProcess();
                    break;
                case '6':
                    CallTestProgramm();
                    break;
                case '7':
                    OpenBrowser();
                    break;
                default:
                    Console.WriteLine("unknown operation");
                    break;
            }
        } while (key.KeyChar != '0');
    }
    private void GetProcessByPid()
    {
        try
        {
            Console.WriteLine("Enter pid:");
            int pid = Convert.ToInt32(Console.ReadLine());
            var process = Process.GetProcessById(pid);
            Console.WriteLine($"{process.ProcessName}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    private void ShowAllProcessesFilter()
    {
        Process[] processes = Process.GetProcesses();
        Dictionary<String, int> taskManager = new Dictionary<String, int>();
        foreach (var process in processes)
        {
            string processName = string.Empty;
            try
            {
                processName = process.ProcessName;
            }
            catch (Exception)
            {
                processName = "unknown";
            }
            if (taskManager.ContainsKey(processName))
            {
                taskManager[processName] += 1;
            }
            else
            {
                taskManager[processName] = 1;
            }
        }
        foreach (var process in taskManager)
        {
            Console.WriteLine($"{process.Key} {process.Value}");
        }
    }
    private void ShowAllProcesses()
    {
        Process[] processes = Process.GetProcesses();

        foreach (var process in processes)
        {
            Console.WriteLine($"{process.ProcessName} PID: {process.Id}");
        }
    }
    private void CreateProcess()
    {
        Console.WriteLine("Enter programm name: ");
        string? programm = Console.ReadLine();
        if (programm != null)
        {
            Console.WriteLine(Process.Start(programm).Id);
        }
    }
    private void KillProcess()
    {
        Console.WriteLine("Enter process name: ");
        string? processName = Console.ReadLine();
        var processes = Process.GetProcessesByName(processName);
        foreach (var process in processes)
        {
            process.Kill();
            Console.WriteLine("Process is killed");
        }
    }
    private void CallTestProgramm()
    {
        string exePath = @"C:\Users\USER\Desktop\PV521_2\EFCore\SystemProgramming\TestProgramm\bin\Debug\net9.0\TestProgramm.exe";

        string arg = "hi";
        ProcessStartInfo processInfo = new ProcessStartInfo()
        {
            FileName = exePath,
            Arguments = arg,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            CreateNoWindow = true,
        };
        using (Process process = new Process())
        {
            process.StartInfo = processInfo;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            string errors = process.StandardError.ReadToEnd();
            process.WaitForExit();
            Console.WriteLine($"Result: {output}");
        }
    }
    private void OpenBrowser()
    {
        Process.Start(new ProcessStartInfo
        {
            FileName = "https://dou.ua",
            UseShellExecute = true
        });
    }
};
