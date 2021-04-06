using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2_1.Interfaces;

namespace Task2_2_1.Type_of_tanks_and_tank_factory
{
    public abstract class Tank:IAttack,IMovable,IDestroyable
    {
        public  int Health { get; private set; }
        public int Speed { get;private set; }
        public int Damage { get; private set; }
        public TypeOfTank TypeOfTank { get; private set; }

        protected Tank(int hp, int speed, int damage,TypeOfTank type)
        {
            Health = hp;
            Speed = speed;
            Damage = damage;
            TypeOfTank = type;
        }
        public void MoveTo() { }//movement in some direction multiplied by speed
        public void Attack() { }//direction and damage
        public void Destroy() { }//oh shit i'm dying
    }
    public enum TypeOfTank
    {
        FastTank,
        HeavyTank,
        BalancedTank
    }
}
