using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Aron Ly
 * Date: July 13, 2017
 * Description: This is the SuperVillain that inherits from the SuperHuman class
 * Version: 0.1 - Class created
 */
namespace COMP123_S2017_Lesson9B
{
    class SuperVillain : SuperHuman, IHasMalice
    {
        //constructor
        /// <summary>
        /// This is the main constructor for the SuperVillain class
        /// It takes two arguments - name (string) - malice (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="malice"></param>
        public SuperVillain(string name, int malice)
            : base(name)
        {
            this.Malice = malice;
        }
        //private instance variables
        private int _malice;
        //public properties
        public int Malice
        {
            get
            {
                return this._malice;
            }
            set
            {
                this._malice = value;
            }
        }
    }
}
