using System;
using System.Text;

namespace Task3_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAGreating();
            var analyzer = new TextAnalyzer(ArticleInput());
            analyzer.InitializeDictionary();
            var exit = false;
            while (!exit)
            {
                PrintMenu();
                int.TryParse(Console.ReadLine(), out int inp);
                switch (inp)
                {
                    case 1:
                        Console.Clear();
                        ShowFullAnalysis(analyzer);
                        break;
                    case 2:
                        Console.Clear();
                        ShowShortAnalysis(analyzer);
                        break;
                    case 3:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Enter a number between 1 and 3:");
                        break;
                }
            }
        }

        private static string ArticleInput()
        {
            Console.WriteLine("enter text:");
            string str;
            var sb = new StringBuilder();
            while (true)
            {
                str = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(str)) break;
                sb.Append(str + " ");
            }
            return sb.ToString();
        }
        static void PrintAGreating()
        {
            Console.WriteLine("Hi, I am a program that analyzes the text for the monotony of the language." +
                Environment.NewLine + "To start you should enter your article." + Environment.NewLine +
                "To finish the input process press button \"enter\" and enter the empty line.");
        }
        static void PrintMenu()
        {
            Console.WriteLine("Choose action:" + Environment.NewLine +
                "\t1. Show Full Analysis" + Environment.NewLine +
                "\t2. Show Short Analysis" + Environment.NewLine +
                "\t3. Exit" + Environment.NewLine +
                "enter a number of action:");
        }
        static void ShowFullAnalysis(TextAnalyzer analyzer)
        {
            Console.WriteLine("Word\t|\tnumber of appearances");
            Console.WriteLine(new string('-', 50));
            foreach (var word in analyzer.GetFullAnalysis())
            {
                Console.WriteLine($"{word.Key}\t|\tappeared {word.Value} times");
                Console.WriteLine(new string('-', 50));
            }
        }
        static void ShowShortAnalysis(TextAnalyzer analyzer)
        {
            Console.WriteLine("the text is good, but please replace the following words due to frequent use:");
            foreach (var word in analyzer.GetShortAnalysis())
            {
                Console.WriteLine($"\"{word.Key}\" appeared {word.Value} times");
            }
        }
    }
}
