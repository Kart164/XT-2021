using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_1_2
{
    public class Cirlce : Round
    {
        public double Area => Math.PI * Math.Pow(R, 2);
        
        public Cirlce(Point center, double radius) : base(center, radius)
        {
            Type = FigureType.Circle;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
