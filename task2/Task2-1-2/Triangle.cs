using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_1_2
{
    public class Triangle: Figure
    {
        public Line A { get; private set; }
        public Line B { get; private set; }
        public Line C { get; private set; }
        public override FigureType Type => FigureType.Triangle;
        public double Perimeter => A.Length + B.Length + C.Length;
        public double Area => Math.Sqrt((Perimeter / 2) * (Perimeter / 2 - A.Length) *
            (Perimeter / 2 - B.Length)*(Perimeter / 2-C.Length));

        

        public Triangle(Line a,Line b, Line c)
        {
            if (IsValid(a,b,c))
            {
                A = a;
                B = b;
                C = c;
            }
            else throw new Exception($"invalid triangle");
        }
        public static bool IsValid(Line a, Line b, Line c)
        {
            if (a.Length + b.Length > c.Length && b.Length + c.Length > a.Length && c.Length + a.Length > b.Length)
            {
                return true;
            }
            else return false;
        }


        public override string ToString()
        {
            return new string($"{A.Start} {B.Start} {C.Start}, Perimeter={Perimeter}, Area={Area}");
        }
    }
}
