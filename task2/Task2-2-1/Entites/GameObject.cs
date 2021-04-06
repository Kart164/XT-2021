using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2_1
{
    public abstract class GameObject
    {
        public Point Position { get; set; }
        public TypeOfGameObj Type { get; set; }
    }
    public enum TypeOfGameObj
    {
        Player,
        Enemy,
        Obstacle,
        Bonus
    }
}
