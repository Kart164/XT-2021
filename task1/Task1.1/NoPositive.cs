using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._1
{
    public static class NoPositive
    {
        public static void ChangeNums(int[,,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    for (int k = 0; k < mas.GetLength(2); k++)
                        if (mas[i, j, k] > 0)
                            mas[i, j, k] = 0;
        }
        public static void FillArray(int[,,] mas)
        {
            Random rand = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    for (int k = 0; k < mas.GetLength(2); k++)
                        mas[i, j, k] = rand.Next(-100, 100);
        }
        public static void Print(int[,,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                Console.WriteLine($"{i} page of massive:"+Environment.NewLine);
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    for (int k = 0; k < mas.GetLength(2); k++)
                    {
                        Console.Write($"{mas[i,j,k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
