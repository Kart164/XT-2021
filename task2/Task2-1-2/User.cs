using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_1_2
{
    public class User
    {
        public string Name { get; private set; }
        public List<Figure> Figures{get; private set; }
        public User(string name)
        {
            Name = name;
            Figures = new List<Figure>();
        }
        public void AddFigure(Figure figure)
        {
            Figures.Add(figure);
        }
        public void ClearFigures()
        {
            Figures.Clear();
        }

    }
}
