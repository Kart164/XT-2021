using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._2
{
    public static class Averages
    {
        public static double CalculateAvarageLenght(string str)
        {
            var avg = 0d;
            var sb = new StringBuilder();
            foreach(char c in str)
            {
                if (char.IsLetterOrDigit(c)||char.IsWhiteSpace(c))
                    sb.Append(c);
            }
            var mas = (sb.ToString()).Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            if (mas.Length != 0)
            {
                foreach (string item in mas)
                {
                    avg += item.Length;
                }
                return avg/= mas.Length;
            }
            else return avg;
        }
    }
}
