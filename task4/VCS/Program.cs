using System;
using System.IO;

namespace VCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage.SetDirectory(@"C:\Programing\task4\watch");
            var watcher = new Watcher();
            while (string.IsNullOrWhiteSpace(Console.ReadLine())) ;
        }
    }
}
