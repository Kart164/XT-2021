using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2_1.Interfaces;
using Task2_2_1.Type_of_tanks_and_tank_factory;

namespace Task2_2_1.Entites
{
    public class Enemy: GameObject, IMovable, IAttack, IDestroyable
    {
        private Tank _typeOfTank { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }
        public int Damage { get; set; }

        public Enemy(TypeOfTank typeOfTank)
        {
            Type = TypeOfGameObj.Player;
            _typeOfTank = TankFactory.CreateTank(typeOfTank);
            Health = _typeOfTank.Health;
            Speed = _typeOfTank.Speed;
            Damage = _typeOfTank.Damage;
        }

        public void MoveTo()
        {
            _typeOfTank.MoveTo();
        }
        public void Attack()
        {
            _typeOfTank.Attack();
        }
        public void Destroy()
        {
            _typeOfTank.Destroy();
            //some code
        }
    }
}
