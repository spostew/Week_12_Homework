using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_12_Homework
{
    class MarshmellowAlien : Alien
    {
        public int damage = 1; // alien is weak and only does 1 damage
        public int number;

        public MarshmellowAlien() { }
        public MarshmellowAlien(int num, int health, string name) // assign values
        {
            number = num;
            base.health = health;
            base.name = name;
        }

        int getDamage() // return 1
        {
            return damage;
        }

        int calcDamage() // return the number
        {
            return getDamage() * number;
        }

        public override string ToString() // displays the results
        {
            return "The " + name + " alien" + " has " + health + " health with " + calcDamage() + " damage dealt.";
        }
    }
}
