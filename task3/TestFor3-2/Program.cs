using System;
using DynamicArray;

namespace TestFor3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[]{ 1,2,3,4,5,5};
            var dynamic = new DynamicArray<int>(arr);
            dynamic.Add(1);
            foreach (var item in dynamic)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            dynamic.AddRange(new int[] { 3, 2, 1 });
            foreach (var item in dynamic)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            dynamic.Capacity -= 10;
            foreach (var item in dynamic)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            dynamic.Insert(55, -1);

            foreach (var item in dynamic)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine(dynamic[-0]);
            Console.WriteLine(dynamic.ToString());
        }
    }
}
