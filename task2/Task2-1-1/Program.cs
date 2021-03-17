using System;
using UsefullThings;
namespace Task2_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var str = new char[]{'a','b','c' };

            var cha = new StringAsCharArray(str);
            str[0] = '0';
            var cha2 = new StringAsCharArray(str);
            Console.WriteLine(cha.ToString());
        }
    }
}
