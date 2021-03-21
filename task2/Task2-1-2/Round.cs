using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_1_2
{
    public class Round:Figure
    {
        public Point Center { get; set; }
        public double R 
        {
            get => R;
            set
            {
                if (value > 0)
                    R = value;
                else throw new ArgumentException("the radius must be greater than 0", nameof(value));
            }
        }
        public double Length => 2 * Math.PI * R;
        
        public Round(Point center, double radius)
        {
            Center = center;
            R = radius;
            Type = FigureType.Round;
        }
        public override string ToString()
        {
            return new string($"Center={Center} Radius={R}");
        }
    }
}
