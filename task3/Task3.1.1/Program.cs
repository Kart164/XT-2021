using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Task3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //in this task, counter restarts after last deleted person
            Console.WriteLine("Введите N");
            var n = IntInput();
            var survivors = new Survivors(n) ;
            Console.WriteLine("Введите, какой по счету человек будет вычеркнут каждый раунд:");
            survivors.StartGame(CrossOutNumberInput(n));
        }
        static int IntInput()
        {
            int res;
            while(!int.TryParse(Console.ReadLine(), out res) && res > 0)
            {
                Console.WriteLine("Введите значение больше 0");
            }
            return res;
        }
        static int CrossOutNumberInput(int n)
        {
            var res = IntInput();
            while (res > n)
            {
                Console.WriteLine("Вычеркнуть человека с номером большим их колличества нельзя");
                res = IntInput();
            }
            return res;
        }
    }
}
