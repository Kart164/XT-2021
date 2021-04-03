using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2_1.Entites
{
    class Player : GameObject, IMovable, IAttack
    {
        private Tank _typeOfTank { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }  
        public int Damage { get; set; }

    }
}
