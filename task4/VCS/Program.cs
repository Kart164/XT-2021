using System;
using System.IO;
using System.Text.RegularExpressions;

namespace VCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Environment.UserName}, specify the path to the directory " +
                $"in the format C:\\folder\\directoryToWatch:");
            var regex = new Regex(@"[A-Z]:[\\\w]+");
            var path = Console.ReadLine();
            while (!regex.IsMatch(path) && !Directory.Exists(path))
            {
                Console.WriteLine("WRONG FORMAT or directory doesn't exist!!!! try again...");
                path = Console.ReadLine();
            }
            Storage.SetDirectory(path);
            var logger = new Logger();
            logger.SaveStartStateToJson();
            logger.ReadCommits();
            var escape = false;
            while (!escape)
            {
                PrintMenu();
                int.TryParse(Console.ReadLine(), out int result);
                switch (result)
                {
                    case 1:
                        StartMonitoring(logger);
                        break;
                    case 2:
                        RollBackActions(logger);
                        break;
                    case 3:
                        escape = true;
                        break;
                    default:
                        Console.WriteLine("enter a number between 1 and 3");
                        break;
                }
            }
        }
        static void PrintMenu()
        {
            Console.WriteLine("Chose mode:" + Environment.NewLine + "\t1. Monitoring mode"
                + Environment.NewLine + "\t2. Rollback mode" +
                Environment.NewLine + "\t3. Exit");
        }

        static void StartMonitoring(Logger logger)
        {
            Console.WriteLine("write \"commit\" to save changes, or write \"stop\" to end monitoring ");
            var watcher = new Watcher();
            watcher.ChangeHandler += PrintEventInfo;
            var escape = false;
            while (!escape)
            {
                var str = Console.ReadLine();
                switch (str)
                {
                    case "commit":
                        watcher.SaveCommit(logger);
                        break;
                    case "stop":
                        StopMonitoring(logger, watcher);
                        escape = true;
                        break;
                }
            }
        }
        static void StopMonitoring(Logger logger, Watcher watcher)
        {
            var isStoped = false;
            while (!isStoped)
            {
                Console.WriteLine("save last changes?(yes/no):");
                var choose = Console.ReadLine();
                switch (choose)
                {
                    case "yes":
                        watcher.EndMonitoring(logger, true);
                        isStoped = true;
                        break;
                    case "no":
                        watcher.EndMonitoring(logger, false);
                        isStoped = true;
                        break;
                }
            }
        }

        static void RollBackActions(Logger logger)
        {
            Console.WriteLine("1. RollBack to base state" + Environment.NewLine +
                "2. Rollback to Commit" + Environment.NewLine + "3. Exit");
            var str = Console.ReadLine();
            int res;
            while (!int.TryParse(str, out res) || res > 3 || res < 1)
            {
                Console.WriteLine("enter 1 or 2 or 3");
                str = Console.ReadLine();
            }
            switch (res)
            {
                case 1:
                    Rollback.RollBackToInitialState(logger);
                    break;
                case 2:
                    Console.WriteLine("enter index of commit:");
                    for (int i = 0; i < logger.Commits.Count; i++)
                    {
                        Console.WriteLine($"{i}. {logger.Commits[i].DateTimeOfCommit}");
                    }
                    int index;
                    str = Console.ReadLine();
                    while (!int.TryParse(str, out index) || res >= logger.Commits.Count || res < 0)
                    {
                        Console.WriteLine($"enter number between 0 and {logger.Commits.Count}");
                        str = Console.ReadLine();
                    }
                    Rollback.MakeRollBack(res, logger);
                    break;
            }
        }

        static void PrintEventInfo(string str)
        {
            Console.WriteLine(str);
        }
    }
}
