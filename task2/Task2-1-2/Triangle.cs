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
        public double Perimeter => A.Length + B.Length + C.Length;
        public double Area => Math.Sqrt((Perimeter / 2) * (Perimeter / 2 - A.Length) *
            (Perimeter / 2 - B.Length)*(Perimeter / 2-C.Length));
       
        public Triangle(Point point1,Point point2, Point point3)
        {
            var a = new Line(point1, point2);
            var b = new Line(point2, point3);
            var c = new Line(point3, point1);
            if (a.Length + b.Length > c.Length && b.Length + c.Length > a.Length && c.Length + a.Length > b.Length)
            {
                A = a;
                B = b;
                C = c;
            }
            else throw new Exception($"invalid triangle");
            Type = FigureType.Triangle;
        }
       
        public override string ToString()
        {
            return new string($"{A.Start} {B.Start} {C.Start}");
        }
    }
}
