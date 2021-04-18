using System;
using System.Linq;
namespace SuperArrayAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 1, 2, 2, 3, 4, 5, 5 };
            Console.WriteLine(arr.Sum());
            Console.WriteLine(arr.Average());
            var arr2 = arr.MostFrequentElements();
            Console.WriteLine(string.Join(' ',arr2));
            Console.WriteLine();
            var str = "fаrго";
            Console.WriteLine(str.CheckLanguage());
            str = "ffff";
            Console.WriteLine(str.CheckLanguage());
            str = "ёва";
            Console.WriteLine(str.CheckLanguage());

        }
        
    }
}
