using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._2
{
    public static class Validator
    {
        public static string ValidatedString(string str)
        {
            var punctuation = ".?!";
            bool findpunc = false;
            var sb = new StringBuilder(str);
            sb[0] = char.ToUpper(sb[0]);
            for (int i = 0; i < sb.Length; i++)
            {
                if (!findpunc) {
                    if (punctuation.Contains(sb[i]))
                    {
                        findpunc = true;
                        i++;
                    }
                }
                else
                {
                    sb[i] = char.ToUpper(sb[i]);
                    findpunc = false;
                    i++;
                }
            }
            return sb.ToString();
        }
    }
}
