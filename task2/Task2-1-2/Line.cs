using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_1_2
{
    public class Line:Figure
    {
        public Point Start {
            get => Start;
            set 
            {
                if (value == End)
                    throw new ArgumentException($"the line must start and end at different points." +
                        $" Start as {nameof(value)}={nameof(End)}", nameof(value));
                else Start = value;
            } 
        }
        public Point End {
            get => End;
            set
            {
                if (value == Start)
                    throw new ArgumentException($"the line must start and end at different points." +
                        $" End as {nameof(value)}={nameof(Start)}", nameof(value));
                else End = value;
            }
        }
        
        public Line(Point start, Point end)
        {
            if(start==end)
            Start = start;
            End = end;
            Type = FigureType.Line;
        }
        
        public double Length { get => Math.Sqrt(Math.Pow(Start.X - End.X, 2) + Math.Pow(Start.Y - End.Y, 2)); }

        public override string ToString()
        {
            return new string($"{Start} {End}");
        }


    }
}
