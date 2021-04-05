using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2_1.Interfaces;
using Task2_2_1.Type_of_tanks_and_tank_factory;

namespace Task2_2_1.Entites
{
    class Player : GameObject, IMovable, IAttack, IDestroyable
    {
        public Tank TypeOfTank { get; private set; }
        public int Health { get; set; }
        public int Speed { get; set; }  
        public int Damage { get; set; }

        public Player(TypeOfTank typeOfTank)
        {
            Type = TypeOfGameObj.Player;
            TypeOfTank = TankFactory.CreateTank(typeOfTank);
            Health = TypeOfTank.Health;
            Speed = TypeOfTank.Speed;
            Damage = TypeOfTank.Damage;
        }

        public void MoveTo()
        {
            TypeOfTank.MoveTo();
        }
        public void Attack()
        {
            TypeOfTank.Attack();
        }
        public void Destroy()
        {
            TypeOfTank.Destroy();
            //some code
        }

        public void PickUpBonus(Bonus bonus) { }
    }
}
