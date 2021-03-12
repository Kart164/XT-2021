using System;

namespace Task1._2
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
                while (!int.TryParse(Console.ReadLine(), out value))
                    Console.WriteLine("enter a number between 1 and 5");
                switch (value)
                {
                    case 1:
                        Console.Clear();
                        DoTask1();
                        break;
                    case 2:
                        Console.Clear();
                        DoTask2();
                        break;
                    case 3:
                        Console.Clear();
                        DoTask3();
                        break;
                    case 4:
                        Console.Clear();
                        DoTask4();
                        break;
                    case 5:
                        escape = true;
                        break;
                }
            }
        }
        static void PrintMenu()
        {
            Console.WriteLine("Choose task:" + Environment.NewLine + "\t1. Averages"
                + Environment.NewLine + "\t2. Doubler" + Environment.NewLine + "\t3. Lowercase"
                + Environment.NewLine + "\t4. Validator" + Environment.NewLine + "enter 5 to exit");
        }
        private static void DoTask1()//не округлял
        {
            Console.Write("Task 1.2.1 Averages"+Environment.NewLine+"Enter string:");
            var res=Averages.CalculateAvarageLenght(Console.ReadLine());
            Console.WriteLine($"avarage length of word = {res}");
        }
        private static void DoTask2()
        {
            Console.Write("Task 1.2.2 Doubler" + Environment.NewLine + "Enter first string:");
            var str1 = Console.ReadLine();
            Console.Write("Enter second string:");
            var str2 = Console.ReadLine();
            str1 = Doubler.DoubleChars(str1, str2);
            Console.WriteLine($"result: {str1}");
        }
        private static void DoTask3()
        {
            Console.Write("Task 1.2.3 Lowercase" + Environment.NewLine + "Enter string:");
            var res = Lowercase.CountOfLowerCaseWords(Console.ReadLine());
            Console.WriteLine($"Count of lower case words = {res}");
        }
        private static void DoTask4()
        {
            Console.Write("Task 1.2.4 Validator" + Environment.NewLine + "Enter string:");
            var res = Validator.ValidatedString(Console.ReadLine());
            Console.WriteLine($"Corrected string: {res}");
        }
    }
}
