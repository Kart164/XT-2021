using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_1_2
{
    public class Line:Figure
    {
        public Point Start { get; private set; }
        public Point End { get; private set; }
        public override FigureType Type => FigureType.Line;
        public double Length { get => Math.Sqrt(Math.Pow(Start.X - End.X, 2) + Math.Pow(Start.Y - End.Y, 2)); }

        public Line(Point start, Point end)
        {
            if (!start.Equals(end))
            {
                Start = start;
                End = end;
            }
            else throw new ArgumentException("the line must start and end at different points.");
        }
        
        public override string ToString()
        {
            return new string($"{Start} {End} Length={Length}");
        }
    }
}
