using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_1_2
{
    public class Ring:Figure
    {
        public override FigureType Type => FigureType.Ring;
        public double Area => OuterCircle.Area - InnerCircle.Area;
        public Cirlce InnerCircle { get; private set; }
        public Cirlce OuterCircle { get; private set; }
        

        public Ring(Point center,double innerRadius,double outerRadius)
        {
            if (innerRadius <= outerRadius && innerRadius>0 && outerRadius>0)
            {
                OuterCircle = new Cirlce(center, outerRadius);
                InnerCircle = new Cirlce(center, innerRadius);
            }
            else throw new Exception("invalid ring");
        }

        public override string ToString()
        {
            return new string($"Inner Cirle={InnerCircle}, Outer Circle={OuterCircle}, Area={Area}");
        }

    }
}
