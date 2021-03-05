using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._1
{
    public static class FontMass
    {
        [Flags]
        private enum Fonts
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4
        }
        private static void Information(Fonts font)
        {
            Console.WriteLine($"Параметры надписи: {font}");
            Console.WriteLine("Введите:");
            for (int i = 1, j = 1; i <= 4; i *= 2, j++)
            {
                Console.WriteLine($"\t{j}: {(Fonts)i}");
            }
            Console.WriteLine($"\t4 - to exit");
        }
        public static void DoTask()
        {
            int fontvalue;
            Fonts font = Fonts.None;
            bool escape_case = true;
            while (escape_case)
            {
                Information(font);
                
                while (!int.TryParse(Console.ReadLine(), out fontvalue) || fontvalue < 0 || fontvalue > 4)
                {
                    Console.WriteLine("enter value between 1 and 4");
                }
                switch (fontvalue)
                {
                    case 1:
                        if (font.HasFlag(Fonts.Bold))
                            font ^= Fonts.Bold;
                        else
                            font |= Fonts.Bold;
                        break;

                    case 2:
                        if (font.HasFlag(Fonts.Italic))
                            font ^= Fonts.Italic;
                        else
                            font |= Fonts.Italic;
                        break;

                    case 3:
                        if (font.HasFlag(Fonts.Underline))
                            font ^= Fonts.Underline;
                        else
                            font |= Fonts.Underline;
                        break;

                    case 4:
                        escape_case = false;
                        break;
                    default:
                        font = Fonts.None;
                        break;
                }
            }
        }
    }
}
