using System;

namespace SuperArrayAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr= { 1, 2,2, 3, 4, 5 ,5};
            Console.WriteLine(arr.Median());
            var arr2 = arr.MostFrequentElement();
            foreach (var item in arr2)
            {
                Console.Write($"{item} ");
            }
        }
        
    }
}
