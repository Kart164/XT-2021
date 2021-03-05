using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DoArrayPocessing();
            //FontMass.DoTask();
        }

        private static void DoArrayPocessing()
        {
            var arr = new ArrayProcessing(100);
            arr.PrintMas();
            Console.WriteLine(System.Environment.NewLine + "Sorted mass:");
            arr.QuickSort(0, 100 - 1);
            arr.PrintMas();
            Console.WriteLine(System.Environment.NewLine + $"max = {arr.Max}, min = {arr.Min}");
        }





    }
}
