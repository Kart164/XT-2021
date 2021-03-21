using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_1_2
{
    public class Rectangle : Figure
    {
        public Line[] Lines { get; private set; }
        public FigureType SubType { get; private set; }
        public double Perimeter
        {
            get
            {
                var p = 0d;
                for (int i = 0; i < 4; i++)
                {
                    p += Lines[i].Length;
                }
                return p;
            }
        }
        public double Area => Lines[0].Length * Lines[1].Length;

        public Rectangle()
        {
            Type = FigureType.Rectangle;
        }
        public Rectangle(Point p1,Point p2,Point p3,Point p4)
        {
            var l1 = new Line(p1, p2);
            var l2 = new Line(p2, p3);
            var l3 = new Line(p3, p4);
            var l4 = new Line(p4, p1);
            if ((l1.Length == l3.Length) && (l2.Length == l4.Length))
            {
                if (l1.Length == l2.Length)
                {
                    SubType = FigureType.Square;
                    Lines = new Line[] { l1, l2, l3, l4 };
                    Type = FigureType.Rectangle;
                }
                else
                {
                    Lines = new Line[] { l1, l2, l3, l4 };
                    Type = FigureType.Rectangle;
                    SubType = FigureType.Rectangle;
                }
            }
        }
        public override string ToString()
        {
            return new string($"{Lines[0].Start} {Lines[1].Start} {Lines[2].Start} {Lines[3].Start}");
        }
    }
}
