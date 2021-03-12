using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._1
{
    public static class _2DArray
    {
        public static int[,] FillArray(int[,] mas)
        {
            var rand = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rand.Next(0,10);
                }
            }
            return mas;
        }
        public static int SumOfEvenPositions(int[,]mas)
        {
            var sum = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < mas.GetLength(1); j += 2)
                    {
                        sum += mas[i, j];
                    }
                }
                else
                {
                    for (int j = 1; j < mas.GetLength(1); j += 2)
                    {
                        sum += mas[i, j];
                    }
                }
            }
            return sum;
        }
        public static void Print(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write($"{mas[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
