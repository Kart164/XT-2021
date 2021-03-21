using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_1_2
{
    abstract public class Figure
    {
        public FigureType Type { get; protected set; } = FigureType.Figure;
    }

    public enum FigureType
    {
        Figure,
        Line,
        Circle,
        Round,
        Ring,
        Square,
        Rectangle,
        Triangle
    }
}
