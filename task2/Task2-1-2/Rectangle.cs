using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_1_2
{
    public class Rectangle : Figure
    {
        public Line[] Lines { get; private set; }
        public override FigureType Type => FigureType.Rectangle;
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

        

       
        public Rectangle(Line l1, Line l2, Line l3, Line l4)
        {
            if (IsValid(l1,l2,l3,l4))
            {
                if (l1.Length == l2.Length && l2.Length==l3.Length&&l3.Length==l4.Length)
                {
                    SubType = FigureType.Square;
                    Lines = new Line[] { l1, l2, l3, l4 };
                }
                else
                {
                    Lines = new Line[] { l1, l2, l3, l4 };
                    SubType = FigureType.Rectangle;
                }
            }
            else throw new Exception("it's not a rectangle!!");
        }
        public static bool IsValid(Line l1,Line l2,Line l3, Line l4)
        {
            if ((l1.Length + l2.Length + l3.Length) > l4.Length && (l2.Length + l3.Length + l4.Length) > l1.Length
                && (l1.Length + l3.Length + l4.Length) > l2.Length && (l1.Length + l2.Length + l4.Length) > l3.Length)
            {
                return true;
            }
            else return false;

        }
        public override string ToString()
        {
            return new string($"{Lines[0].Start} {Lines[1].Start} {Lines[2].Start} {Lines[3].Start}, Perimeter={Perimeter}, Area={Area}");
        }
    }
}
