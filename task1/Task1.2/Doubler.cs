using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._2
{
    public  static class Doubler
    {
        public static string DoubleChars(string str1,string str2)
        {
            var sb1 = new StringBuilder(str1.ToLower());
            var sb2 = new StringBuilder();
            str2 = str2.ToLower();
            foreach (char c in str2)
            {
                if (char.IsLetterOrDigit(c))
                    sb2.Append(c);
            }
            for (int i = 0; i < sb2.Length; i++)
            {
                if (i == str2.LastIndexOf(str2[i]))
                {
                    sb1.Replace($"{sb2[i]}", new string(sb2[i],2));
                }
            }
            return sb1.ToString();
        }
    }
}
