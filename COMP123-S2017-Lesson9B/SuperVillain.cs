using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Aron Ly
 * Date: July 13, 2017
 * Description: This is the SuperVillain subclass that extends the SuperHuman class
 * Version: 0.1 - Class created
 */
namespace COMP123_S2017_Lesson9B
{
    class SuperVillain : SuperHuman, IHasMalice
    {
        public SuperVillain(string name)
            : base(name)
        {

        }
        
    }
}
