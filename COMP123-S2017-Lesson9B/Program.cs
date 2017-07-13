using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Aron Ly
 * Date: July 13, 2017
 * Description: Demo for Lesson 9
 * Version: 0.5 - implemented the ToString method of the superhuman class
 */

namespace COMP123_S2017_Lesson9B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.AddPower("Spider Climbing", 50);
            superHuman.AddPower("Webcasting", 40);
            superHuman.DisplayPowers();
            Console.WriteLine(superHuman.ToString());

        }
    }
}
