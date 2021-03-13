using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._2
{
    public static class Lowercase
    {
        public static int CountOfLowerCaseWords(string str)
        {
            var count = 0;
            if (str.Length > 0)
            {
                var sb = new StringBuilder();
                foreach (char c in str)
                {
                    if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
                        sb.Append(c);
                }
                var mas = (sb.ToString()).Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (string s in mas)
                {
                    if (char.IsLower(s[0]))
                        count++;
                }
            }
            return count;
        }
    }
}
