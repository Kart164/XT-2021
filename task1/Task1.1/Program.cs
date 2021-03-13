using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escape = false;
            int value;
            while (!escape)
            {
                PrintMenu();
                while(!int.TryParse(Console.ReadLine(),out value))
                    Console.WriteLine("enter a number between 1 and 11");
                switch (value)
                {
                    case 1:
                        Console.Clear();
                        TasksWithFigures.DoTask1();
                        break;
                    case 2:
                        Console.Clear();
                        TasksWithFigures.DoTask2();
                        break;
                    case 3:
                        Console.Clear();
                        TasksWithFigures.DoTask3();
                        break;
                    case 4:
                        Console.Clear();
                        TasksWithFigures.DoTask4();
                        break;
                    case 5:
                        Console.Clear();
                        SumOfNums.DoTask();
                        break;
                    case 6:
                        Console.Clear();
                        FontMass.DoTask();
                        break;
                    case 7:
                        Console.Clear();
                        DoArrayPocessing();
                        break;
                    case 8:
                        Console.Clear();
                        DoNoPositive();
                        break;
                    case 9:
                        Console.Clear();
                        DoNonNegative();
                        break;
                    case 10:
                        Console.Clear();
                        Do2DArray();
                        break;
                    case 11:
                        escape = true;
                        break;
                    default:
                        break;
                }
            }
        }
        private  static void PrintMenu()
        {
            Console.WriteLine("Choose task:"+Environment.NewLine+"\t1. Rectangle"
                +Environment.NewLine+"\t2. Trinangle"+Environment.NewLine+"\t3. Another triangle"
                +Environment.NewLine+"\t4. Xmas tree"+Environment.NewLine+"\t5. Sum of Nubers"
                +Environment.NewLine+"\t6. Font Adjusment"+ Environment.NewLine+"\t7. Array Processing"
                +Environment.NewLine+"\t8. No Positive"+Environment.NewLine+"\t9. Non-Negative Sum"
                +Environment.NewLine+"\t10. 2D Array"+Environment.NewLine+"Enter 11 to exit");
        }
        /* Написать программу, которая генерирует случайным образом элементы массива (число элементов в массиве и их тип определяются разработчиком),
         * определяет для него максимальное и минимальное значения, сортирует массив и выводит полученный результат на экран.
       Примечание: LINQ запросы и готовые функции языка (Sort, Max и т.д.) использовать в данном задании запрещается.*/
        private static void DoArrayPocessing()
        {
            Console.WriteLine("Task 1.1.7 Array Processing");
            var arr = new ArrayProcessing(100);
            arr.PrintMas();
            Console.WriteLine(System.Environment.NewLine + "Sorted mass:");
            arr.QuickSort();
            arr.PrintMas();
            Console.WriteLine(System.Environment.NewLine + $"max = {arr.Max}, min = {arr.Min}");
        }
        /*Написать программу, которая заменяет все положительные элементы в трёхмерном массиве на нули.
         * Число элементов в массиве и их тип определяются разработчиком. */
        private static void DoNoPositive()
        {
            Console.WriteLine("Task 1.1.8 NO POSITIVE");
            var mas = new int[10, 10, 5];
            NoPositive.FillArray(mas);
            NoPositive.Print(mas);
            NoPositive.ChangeNums(mas);
            Console.WriteLine(Environment.NewLine+Environment.NewLine+"AFTER CHANGE:");
            NoPositive.Print(mas);  
        }
        /*Написать программу, которая определяет сумму неотрицательных элементов в одномерном массиве.
         * Число элементов в массиве и их тип определяются разработчиком. */
        private static void DoNonNegative()
        {
            Console.WriteLine("Task 1.1.9 Non-Negative Sum");
            var rand = new Random();
            var mas = new int[15];
            var sum = 0;
            Console.WriteLine("Array:");
            for (int i = 0; i < mas.Length; i++)
            {
                
                mas[i] = rand.Next(-100, 100);
                Console.Write($"{mas[i]} ");
                if (mas[i] > 0) sum += mas[i];
            }
            Console.WriteLine(Environment.NewLine+$"Non-negative sum = {sum}");

        }
        private static void Do2DArray()
        {
            Console.WriteLine("Task 1.1.10 2D Array");
            var mas = new int[5,5];//{ { 1, 0, 1, 0 },{ 0, 1, 0, 1 },{ 1, 0, 1, 0 },{ 0, 1, 0, 1 }  };
            _2DArray.FillArray(mas);
            _2DArray.Print(mas);
            var sum = _2DArray.SumOfEvenPositions(mas);
            Console.WriteLine($"sum = {sum}");
        }



    }
}
