using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_1_2
{
    abstract public class Figure
    {
        public abstract FigureType Type { get; }
        protected Figure() { }
    }

    public enum FigureType
    {
        Figure,
        Line,
        Round,
        Circle,
        Ring,
        Square,
        Rectangle,
        Triangle
    }
}
