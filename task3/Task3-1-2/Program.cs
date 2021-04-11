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
            int inp;
            while (!exit){
                PrintMenu();
                while (!int.TryParse(Console.ReadLine(),out inp) || inp > 3 || inp < 1)
                {
                    Console.WriteLine("Enter a number between 1 and 3:");
                }
                switch (inp)
                {
                    case 1:
                        Console.Clear();
                        analyzer.ShowFullAnalysis();                        
                        break;
                    case 2:
                        Console.Clear();
                        analyzer.ShowShortAnalysis();
                        break;
                    case 3:
                        exit = true;
                        break;
                }
            }
        }

        private static string ArticleInput()
        {
            Console.WriteLine("enter text:");
            string str;
            var sb = new StringBuilder();
            var escape = false;
            while (!escape)
            {
                str = Console.ReadLine();
                if (str != "stop")
                {
                    sb.Append(str + " ");
                }
                else
                {
                    escape = true;
                }
            }
            return sb.ToString();
        }
        static void PrintAGreating()
        {
            Console.WriteLine("Hi, I am a program that analyzes the text for the monotony of the language."+
                Environment.NewLine + "To start you should enter your article." + Environment.NewLine+
                "To finish the input process press button \"enter\" and enter the stop.");
        }
        static void PrintMenu()
        {
            Console.WriteLine("Choose action:"+Environment.NewLine+
                "\t1. Show Full Analysis"+ Environment.NewLine+
                "\t2. Show Short Analysis"+ Environment.NewLine+
                "\t3. Exit"+Environment.NewLine+
                "enter a number of action:");
        }
    }
}
