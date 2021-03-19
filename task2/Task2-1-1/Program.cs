using System;
using UsefullThings;
namespace Task2_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var str = "abc";
            var cha = new StringAsCharArray(str);
            str = "bac";
            var cha2 = new StringAsCharArray(str);
            cha.Concat(cha2);
            Console.WriteLine(cha.ToString());
            Console.WriteLine(cha.Length);
        }
    }
}
