using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1_1_1();
            //Task1_1_2();
            //Task1_1_3();
            //Task1_1_4();
            //Task1_1_5();
        }

        public static void Task1_1_5()
        {
            Console.WriteLine("Task1.1.5 Sum Of numbers");
            var sum = 0;
            for (int i = 3; i < 1000; i++)
            {
                if (i % 5 == 0 || i % 3 == 0)
                    sum += i;
            }
            Console.WriteLine($"sum = {sum}");
        }

        public static void Task1_1_4()
        {
            Console.WriteLine("Task1.1.4 Xmas Tree");
            Console.WriteLine("enter n:");
            var n = MakeConsoleInput();
            for (int i = 1; i <= n; i++)
                PrintTriangle(1, n - 1, n - i);
        }

        public static void Task1_1_3()//print full triangle
        {
            Console.WriteLine("Task1.1.2 Another triangle");
            Console.WriteLine("enter n:");
            var n = MakeConsoleInput();
            PrintTriangle(1, n - 1,0);
        }

        public static void PrintTriangle(int stars, int spaces, int minCountOfSpaces)
        {
            if (spaces >= minCountOfSpaces)
            {
                PrintSpaces(spaces);
                PrintStars(stars);
                Console.Write(System.Environment.NewLine);
                PrintTriangle(stars + 2, spaces-1,minCountOfSpaces);
            }
        }
        public static void PrintSpaces(int spaces)
        {
            for (int i = 0; i < spaces; i++)
            {
                Console.Write(' ');
            }
        }
        public static void PrintStars(int stars)
        {
            for (int i = 0; i < stars; i++)
            {
                Console.Write('*');
            }
        }

        public static void Task1_1_2()//Print triangle
        {
            Console.WriteLine("Task1.1.2 Triangle");
            Console.WriteLine("enter n:");
            var n = MakeConsoleInput();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write('*');
                }
                Console.Write(System.Environment.NewLine);
            }
        }

        public static void Task1_1_1()
        {
            Console.WriteLine("Task1.1.1 Rectangle");
            Console.WriteLine("enter a: ");
            var a = MakeConsoleInput();
            Console.WriteLine("enter b: ");
            var b = MakeConsoleInput();
            var area = RectangleArea(a, b);
            Console.WriteLine($"rectangle area = {area}");
        }

        public static int MakeConsoleInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(),out input)|| input<1)
            {
                Console.WriteLine("incorrect input, please enter a positive number");
            }
            return input;
        }
        public static Func<int, int, int> RectangleArea = (a, b) => a * b;
    }
}
