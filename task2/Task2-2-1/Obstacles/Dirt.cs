using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2_1.Entites;

namespace Task2_2_1.Obstacles
{
    public class Dirt:Obstacle
    {
        public Dirt(Point position):base(position,TypeOfObstacles.Dirt)
        {

        }

        public void Slowdown() { }
    }
}
