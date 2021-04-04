using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_1_2
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x,double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return new string($"({X}, {Y})");
        }
        public bool Equals(Point point)
        {
            if (X == point.X && Y == point.Y)
                return true;
            else return false;
        }
    }
}
