using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._1
{
    public static class SumOfNums
    {
        public static void DoTask()
        {
            Console.WriteLine("Task1.1.5 Sum Of numbers");
            var sum = 0;
            for (int i = 3; i < 1000; i++)
            {
                if (i % 5 == 0 || i % 3 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"sum = {sum}");
            //sum = ((2 * 3 + 3 * 332) / 2) * 333 + ((2 * 5 + 5 * 198) / 2) * 199; //это попытка решения другим способом, но с пересечениями
            //Console.WriteLine($"sum = {sum}");
        }
    }
}
