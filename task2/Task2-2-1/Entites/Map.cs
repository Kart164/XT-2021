using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2_1.Entites
{
    public class Map
    {
        public int Size { get; private set; }
        public GameObject[,] MapWithGameObjects { get; private set; }

        public Map(int mapSize)
        {
            Size = mapSize;
            MapWithGameObjects = new GameObject[mapSize, mapSize];
        }

        public void FillMap() { }
    }
}
