/*
 * Alien: This program shows how to turn a static program into a more object oriented based program.
 * It uses different alien type to show how each one could be altered differently without affecting the others
 * Name: Spencer Unitt
 * Module: Homework 12, Week 12
 * 
 * Algorithm:
 * 1. Use a file given as a template to start. The file should contain multiple aliens with different stats
 * 2. Split each alien into their own class and create a variable that stores the unique damage of each one
 * 3. Create a get damage function in each class that returns the base damage the alien does and create
 *    a new function named calcDamage that multiplies the damage by the amount of strikes the alien does
 * 4. Override the ToString function the display the alien name, health, and damage done
 * 5. In main, create a new object from each alien and add the stats to them. Display the results in each object to user
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_12_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates new alien objects
            Alien a1 = new SnakeAlien(25, 80, "Snake");
            Alien a2 = new OgreAlien(75, 100, "Ogre");
            Alien a3 = new MarshmellowAlien(2, 44, "Marshmellow");

            // displays results to user
            Console.WriteLine(a1.ToString());
            Console.WriteLine(a2.ToString());
            Console.WriteLine(a3.ToString());


            Console.ReadLine();
        }
    }
}
