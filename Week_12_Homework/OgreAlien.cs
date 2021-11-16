using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_12_Homework
{
    class OgreAlien : Alien
    {
        public int damage = 6; // damage from ogre is always 6
        public int number;

        public OgreAlien() { }
        public OgreAlien(int num, int health, string name) // assign values
        {
            number = num;
            base.health = health;
            base.name = name;
        }

        int getDamage() // return 6
        {
            return damage;
        }

        int calcDamage() // returns the damage dealt
        {
            return getDamage() * number;
        }

        public override string ToString() // displays results
        {
            return "The " + name + " alien" + " has " + health + " health with " + calcDamage() + " damage dealt.";
        }

    }
}
