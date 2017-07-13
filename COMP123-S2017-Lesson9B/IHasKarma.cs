using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Aron Ly
 * Date: July 13, 2017
 * Description: This Interface lists the signature for any Super Hero subclass
 * Version: 0.1 - Declared the Karma property
 */

namespace COMP123_S2017_Lesson9B
{
    public interface IHasKarma
    {
        //public properties
        int Karma { get; set; }
    }
}
