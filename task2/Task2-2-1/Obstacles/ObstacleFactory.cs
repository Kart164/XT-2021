using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2_1.Entites;
using Task2_2_1.Interfaces;

namespace Task2_2_1.Obstacles
{
    public class ObstacleFactory:IObstacleFactory
    {
        public static Obstacle CreateObstacle(Point position, TypeOfObstacles type)
        {
            return type switch
            {
                TypeOfObstacles.DestructibleWall => new DestructibleWall(position),
                TypeOfObstacles.IndestructibleWall => new IndestructibleWall(position),
                TypeOfObstacles.Dirt => new Dirt(position),
                _ => throw new Exception("this type of obstacle doesn't exists")
            };
        }
    }
}
