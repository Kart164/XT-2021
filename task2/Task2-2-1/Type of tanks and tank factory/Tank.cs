using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2_1.Type_of_tanks_and_tank_factory
{
    public abstract class Tank:GameObject,IAttack,IMovable,IDestroyable
    {
        protected int _maxHP { get; private set; }
        protected int _maxSpeed { get; private set; }
        protected int _maxDamage { get; private set ; }
        public  int Health { get; set; }
        public int Speed { get; set; }
        public int Damage { get; set; }
        public TypeOfTank TypeOfTank { get; private set; }

        protected Tank(int MaxHP, int maxSpeed, int maxDamage,TypeOfTank type)
        {
            Position = null;
            _maxHP = MaxHP;
            _maxSpeed = maxSpeed;
            _maxDamage = maxDamage;
            Health = MaxHP;
            Speed = maxSpeed;
            Damage = maxDamage;
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
