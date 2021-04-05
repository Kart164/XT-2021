using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2_1.Entites
{
    public abstract class Obstacle:GameObject
    {
        public TypeOfObstacles TypeOfObstacles { get; private set; }

        public Obstacle(Point position,TypeOfObstacles type)
        {
            Type = TypeOfGameObj.Obstacle;
            Position = position;
            TypeOfObstacles = type;
        }
    }
    public enum TypeOfObstacles
    {
        IndestructibleWall,
        DestructibleWall,
        Dirt
    }
}
