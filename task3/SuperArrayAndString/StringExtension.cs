using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SuperArrayAndString
{
    public static class StringExtension
    {
        private static Regex eng = new(@"^[A-Za-z]+\b");
        private static Regex rus = new(@"^[А-ЯЁа-яё]+\b");
        private static Regex num = new(@"^[0-9]+\b");

        public static LanguageOfString CheckLanguage(this string str)
        {
            if (eng.IsMatch(str))
            {
                return LanguageOfString.English;
            }
            else if (rus.IsMatch(str))
            {
                return LanguageOfString.Russian;
            }
            else if (num.IsMatch(str))
            {
                return LanguageOfString.Number;
            }
            else return LanguageOfString.Mixed;
        }
    }
    public enum LanguageOfString
    {
        Russian,
        English,
        Number,
        Mixed
    }
}
