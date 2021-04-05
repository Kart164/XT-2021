using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2_1.Entites;
using Task2_2_1.Interfaces;

namespace Task2_2_1.Obstacles
{
    public class DestructibleWall:Obstacle,IDestroyable
    {
        public DestructibleWall(Point position):base(position,TypeOfObstacles.DestructibleWall)
        {

        }

        public void Destroy() { }
    }
}
