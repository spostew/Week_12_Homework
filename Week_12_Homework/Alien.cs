using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_12_Homework
{
    class Alien
    {
        protected int health; // 0 = dead 100 = full
        protected string name; // stores the name

        // basic constructors that assign values to the variables above when called
        public Alien() { }
        public Alien(int h, string n)
        {
            health = h;
            name = n;
        }
    }
}
