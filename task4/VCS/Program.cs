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
            while (!regex.IsMatch(path))
            {
                Console.WriteLine("WRONG FORMAT!!!! try again...");
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
                        //todo: rollback menu
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
            Console.WriteLine("Chose mode:"+ Environment.NewLine+ "\t1. Monitoring mode"
                +Environment.NewLine+"\t2. Rollback mode"+
                Environment.NewLine+"\t3. Exit");
        }

        static void StartMonitoring(Logger logger)
        {
            Console.WriteLine("write \"commit\" to save changes, or write \"stop\" to end monitoring ");
            var watcher = new Watcher();
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
                        break;
                    default:
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
                        watcher.End(logger, true);
                        isStoped = true;
                        break;
                    case "no":
                        watcher.End(logger, false);
                        isStoped = true;
                        break;
                }
            }
        }
    }
}
