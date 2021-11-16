using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_12_Homework
{
    class SnakeAlien : Alien
    {
        // The snake will deal 10 damage per hit?
        public int damage = 10;
        public int number;

        public SnakeAlien() { }
        public SnakeAlien(int num, int health, string name) // Assign the values
        {
            number = num;
            base.health = health;
            base.name = name;
        }

        int getDamage() // return 10
        {
            return damage;
        }

        int calcDamage() // return 10 * number of hits?
        {
            return getDamage() * number;
        }

        public override string ToString() // displays results
        {
            return "The " + name + " alien" + " has " + health + " health with " + calcDamage() + " damage dealt.";
        }

    }
}
