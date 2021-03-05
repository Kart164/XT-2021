using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._1
{
    public static class TasksWithFigures
    {
        public static void DoTask1()
        {
            Console.WriteLine("Task1.1.1 Rectangle");
            Console.WriteLine("enter a: ");
            var a = MakeConsoleInput(1);
            Console.WriteLine("enter b: ");
            var b = MakeConsoleInput(1);
            var area = RectangleArea(a, b);
            Console.WriteLine($"rectangle area = {area}");
        }
        public static void DoTask2()
        {
                Console.WriteLine("Task1.1.2 Triangle");
                Console.WriteLine("enter n:");
                var n = MakeConsoleInput(2);
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write('*');
                    }
                    Console.Write(System.Environment.NewLine);
                }
        }
        public static void DoTask3()//print full triangle
        {
            Console.WriteLine("Task1.1.2 Another triangle");
            Console.WriteLine("enter n:");
            var n = MakeConsoleInput(2);
            PrintTriangle(1, n - 1, 0);
        }
        public static void DoTask4()
        {
            Console.WriteLine("Task1.1.4 Xmas Tree");
            Console.WriteLine("enter n:");
            var n = MakeConsoleInput(2);
            for (int i = 1; i <= n; i++)
                PrintTriangle(1, n - 1, n - i);
        }
        private static void PrintTriangle(int stars, int spaces, int minCountOfSpaces)
        {
            if (spaces >= minCountOfSpaces)
            {
                PrintSpaces(spaces);
                PrintStars(stars);
                Console.Write(System.Environment.NewLine);
                PrintTriangle(stars + 2, spaces - 1, minCountOfSpaces);
            }
        }
        private static void PrintSpaces(int spaces)
        {
            for (int i = 0; i < spaces; i++)
            {
                Console.Write(' ');
            }
        }
        private static void PrintStars(int stars)
        {
            for (int i = 0; i < stars; i++)
            {
                Console.Write('*');
            }
        }

        private static Func<int, int, int> RectangleArea = (a, b) => a * b;
        public static int MakeConsoleInput(int caseVal)
        {

            int input;
            switch (caseVal) {
                case 1:
                    while (!int.TryParse(Console.ReadLine(), out input) || input < 1)
                    {
                        Console.WriteLine("incorrect input, please enter a positive number");
                        
                    }
                    return input;
                case 2:
                    while (!int.TryParse(Console.ReadLine(), out input) || input < 0)
                    {
                        Console.WriteLine("incorrect input, please enter number>0");
                    }
                    return input;
                default:
                    return int.MinValue;
            }
            
        }
    }
}
